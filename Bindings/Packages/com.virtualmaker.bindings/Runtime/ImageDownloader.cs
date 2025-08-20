using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace VirtualMaker.Bindings
{
    public static class ImageDownloader
    {
        private static readonly Dictionary<string, Task<Texture2D>> _downloadTasks = new();
        private static readonly Dictionary<string, Texture2D> _images = new();
        private static readonly Dictionary<string, Sprite> _sprites = new();
        private static readonly Dictionary<Texture2D, int> _textureRefCount = new();
        private static readonly Dictionary<Sprite, int> _spriteRefCount = new();

        public static async Task<Texture2D> DownloadImageAsync(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                return null;
            }

            url = new System.Uri(url).AbsoluteUri;

            if (_images.TryGetValue(url, out var image))
            {
                if (image != null)
                {
                    _textureRefCount[image]++;
                }

                return image;
            }

            if (_downloadTasks.TryGetValue(url, out var task))
            {
                image = await task;
                if (image != null)
                {
                    _textureRefCount[image]++;
                }

                return image;
            }

            var tcs = new TaskCompletionSource<Texture2D>();
            _downloadTasks[url] = tcs.Task;

            using var webRequest = UnityWebRequestTexture.GetTexture(url, true);

            await webRequest.SendWebRequest();

            if (webRequest.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError($"Failed to download image {url}: {webRequest.error}");
                tcs.SetResult(null);
                _downloadTasks.Remove(url);
                return null;
            }

            image = DownloadHandlerTexture.GetContent(webRequest);
            _downloadTasks.Remove(url);
            image.name = url;
            _images[url] = image;
            _textureRefCount[image] = 1;
            tcs.SetResult(image);
            return image;
        }

        public static async Task<Sprite> DownloadSpriteAsync(string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                return null;
            }

            url = new System.Uri(url).AbsoluteUri;

            if (_sprites.TryGetValue(url, out var sprite))
            {
                _spriteRefCount[sprite]++;
                _textureRefCount[sprite.texture]++;
                return sprite;
            }

            var image = await DownloadImageAsync(url);
            if (image == null)
            {
                return null;
            }

            if (_sprites.TryGetValue(url, out sprite))
            {
                _spriteRefCount[sprite]++;
                return sprite;
            }

            sprite = Sprite.Create(image, new Rect(0, 0, image.width, image.height), Vector2.zero);
            sprite.name = url;
            _sprites[url] = sprite;
            _spriteRefCount[sprite] = 1;
            return sprite;
        }

        public static void ReleaseSprite(Sprite sprite)
        {
            if (sprite == null)
            {
                return;
            }

            ReleaseImage(sprite.texture);

            var count = --_spriteRefCount[sprite];
            if (count > 0)
            {
                return;
            }

            _sprites.Remove(_sprites.First(x => x.Value == sprite).Key);
            _spriteRefCount.Remove(sprite);
            sprite.Destroy();
        }

        public static void ReleaseImage(Texture2D image)
        {
            if (image == null)
            {
                return;
            }

            var count = --_textureRefCount[image];
            if (count > 0)
            {
                return;
            }

            _images.Remove(_images.First(x => x.Value == image).Key);
            _textureRefCount.Remove(image);
            image.Destroy();
        }
    }
}
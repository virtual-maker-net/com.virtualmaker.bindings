#if BINDINGS_WEB_REQUEST && BINDINGS_WEB_REQUEST_TEXTURE

using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace VirtualMaker.Bindings
{
    public class ImageDownloader : MonoBehaviour
    {
        private Dictionary<string, Texture2D> _images = new Dictionary<string, Texture2D>();
        private Dictionary<string, Sprite> _sprites = new Dictionary<string, Sprite>();

        private static ImageDownloader _instance;

        public static ImageDownloader GetOrCreate()
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<ImageDownloader>();
                if (_instance == null)
                {
                    var go = new GameObject("ImageDownloader");
                    _instance = go.AddComponent<ImageDownloader>();
                }
            }

            return _instance;
        }

        public async Task<Texture2D> DownloadImageAsync(string url)
        {
            if (_images.TryGetValue(url, out var image))
            {
                return image;
            }

            _images.Add(url, null);

            using var webRequest = UnityWebRequestTexture.GetTexture(url);
            await webRequest.SendWebRequest();
            if (webRequest.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError($"Failed to download image: {webRequest.error}");
                return null;
            }

            image = DownloadHandlerTexture.GetContent(webRequest);
            _images[url] = image;
            return image;
        }

        public async Task<Sprite> DownloadSpriteAsync(string url)
        {
            if (_sprites.TryGetValue(url, out var sprite))
            {
                return sprite;
            }

            var image = await DownloadImageAsync(url);
            if (image == null)
            {
                return null;
            }

            sprite = Sprite.Create(image, new Rect(0, 0, image.width, image.height), Vector2.zero);
            _sprites[url] = sprite;
            return sprite;
        }
    }
}

#endif
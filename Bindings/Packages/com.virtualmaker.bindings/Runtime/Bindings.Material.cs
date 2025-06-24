using System.Threading.Tasks;
using UnityEngine;

namespace VirtualMaker.Bindings
{
    public partial class Bindings
    {
        public async Task<Texture2D> DownloadImageAsync(string url)
        {
            bool unsubscribed = false;
            _unsubscribe.Add(() => unsubscribed = true);

            var texture = await ImageDownloader.DownloadImageAsync(url);
            if (unsubscribed)
            {
                ImageDownloader.ReleaseImage(texture);
                return null;
            }
            else
            {
                _unsubscribe.Add(() => ImageDownloader.ReleaseImage(texture));
                return texture;
            }
        }

        public async Task<Sprite> DownloadSpriteAsync(string url)
        {
            bool unsubscribed = false;
            _unsubscribe.Add(() => unsubscribed = true);

            var sprite = await ImageDownloader.DownloadSpriteAsync(url);
            if (unsubscribed)
            {
                ImageDownloader.ReleaseSprite(sprite);
                return null;
            }
            else
            {
                _unsubscribe.Add(() => ImageDownloader.ReleaseSprite(sprite));
                return sprite;
            }
        }

        public async void SetTexture(Material material, string propertyName, string url)
        {
            material.SetTexture(propertyName, null);

            var texture = await DownloadImageAsync(url);
            if (texture != null)
            {
                material.SetTexture(propertyName, texture);
            }
        }

        public void BindTexture(Material material, string propertyName, IProperty<string> prop)
        {
            Bind(prop, value => SetTexture(material, propertyName, value));
        }

        public async void SetTexture(Material material, int propertyId, string url)
        {
            material.SetTexture(propertyId, null);

            var texture = await DownloadImageAsync(url);
            if (texture != null)
            {
                material.SetTexture(propertyId, texture);
            }
        }

        public void BindTexture(Material material, int propertyId, IProperty<string> prop)
        {
            Bind(prop, value => SetTexture(material, propertyId, value));
        }

        public async void SetSprite(SpriteRenderer spriteRenderer, string url)
        {
            spriteRenderer.sprite = null;

            var sprite = await DownloadSpriteAsync(url);
            if (sprite != null)
            {
                spriteRenderer.sprite = sprite;
            }
        }

        public void BindSprite(SpriteRenderer spriteRenderer, Property<string> prop)
        {
            Bind(prop, value => SetSprite(spriteRenderer, value));
        }
    }
}
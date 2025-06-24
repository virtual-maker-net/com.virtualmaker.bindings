using UnityEngine;

namespace VirtualMaker.Bindings
{
    public partial class Bindings
    {
        private async void SetTexture(Material material, string propertyName, string url)
        {
            var texture = await ImageDownloader.DownloadImageAsync(url);
            material.SetTexture(propertyName, texture);
            _unsubscribe.Add(() => ImageDownloader.ReleaseImage(texture));
        }

        public void BindTexture(Material material, string propertyName, IProperty<string> prop)
        {
            Bind(prop, value => SetTexture(material, propertyName, value));
        }

        private async void SetTexture(Material material, int propertyId, string url)
        {
            var texture = await ImageDownloader.DownloadImageAsync(url);
            material.SetTexture(propertyId, texture);
            _unsubscribe.Add(() => ImageDownloader.ReleaseImage(texture));
        }

        public void BindTexture(Material material, int propertyId, IProperty<string> prop)
        {
            Bind(prop, value => SetTexture(material, propertyId, value));
        }
    }
}
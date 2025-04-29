using UnityEngine;

namespace VirtualMaker.Bindings
{
    internal static class GameObjectExtensions
    {
        internal static void Destroy(this GameObject gameObject)
        {
            if (gameObject == null) { return; }
            if (Application.isPlaying)
            {
                Object.Destroy(gameObject);
            }
            else
            {
                Object.DestroyImmediate(gameObject);
            }
        }
    }
}
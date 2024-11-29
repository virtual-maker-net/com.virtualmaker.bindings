using UnityEngine;

namespace VirtualMaker.Bindings
{
    internal static class GameObjectExtensions
    {
        internal static void Destroy(this GameObject gameObject)
        {
            if (Application.isPlaying)
            {
                GameObject.Destroy(gameObject);
            }
            else
            {
                GameObject.DestroyImmediate(gameObject);
            }
        }
    }
}
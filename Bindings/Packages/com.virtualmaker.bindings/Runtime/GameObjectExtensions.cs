using UnityEngine;

namespace VirtualMaker.Bindings
{
    public static class GameObjectExtensions
    {
        public static void Destroy(this GameObject gameObject)
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
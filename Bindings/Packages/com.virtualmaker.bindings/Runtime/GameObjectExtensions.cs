using UnityEngine;

namespace VirtualMaker.Bindings
{
    internal static class GameObjectExtensions
    {
        internal static void Destroy(this Object unityObject)
        {
            if (unityObject == null) { return; }
            if (Application.isPlaying)
            {
                Object.Destroy(unityObject);
            }
            else
            {
                Object.DestroyImmediate(unityObject);
            }
        }
    }
}
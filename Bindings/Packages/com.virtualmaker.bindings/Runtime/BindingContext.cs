using System.Threading;
using UnityEngine;

namespace VirtualMaker.Bindings
{
    internal struct BindingContext
    {
        public bool HasUnityObject;
        public Object UnityObject;
        public CancellationToken CancellationToken;

        public BindingContext(Object unityObject, bool hasUnityObject, CancellationToken cancellationToken)
        {
            HasUnityObject = hasUnityObject;
            UnityObject = unityObject;
            CancellationToken = cancellationToken;
        }

        public BindingContext(Object unityObject, CancellationToken cancellationToken) :
            this(unityObject, true, cancellationToken) {}

        public BindingContext(CancellationToken cancellationToken) :
            this(null, false, cancellationToken) {}

        public readonly bool IsValid
            => !CancellationToken.IsCancellationRequested && (!HasUnityObject || UnityObject);
    }
}
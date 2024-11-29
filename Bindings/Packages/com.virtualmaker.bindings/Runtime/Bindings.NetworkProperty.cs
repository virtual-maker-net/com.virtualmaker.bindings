#if UNITY_NETCODE_GAMEOBJECTS
using System;
using Unity.Netcode;

namespace VirtualMaker.Bindings
{
    public partial class Bindings
    {
        public void Bind<T>(NetworkProperty<T> networkVariable, Action<T> action) where T : unmanaged
        {
            action(networkVariable.Value);
            BindDeferred(networkVariable, action);
        }

        public void Bind<T>(NetworkProperty<T> networkVariable, Action action) where T : unmanaged
        {
            action();
            BindDeferred(networkVariable, _ => action());
        }

        public void BindDeferred<T>(NetworkProperty<T> networkVariable, Action<T> action) where T : unmanaged
        {
            var wrapper = new NetworkVariable<T>.OnValueChangedDelegate((_, newValue) => action(newValue));
            networkVariable.OnValueChanged += wrapper;
            AddUnsubscriber(() => networkVariable.OnValueChanged -= wrapper);
        }
    }
}
#endif // UNITY_NETCODE_GAMEOBJECTS
#if UNITY_NETCODE_GAMEOBJECTS
using System;

namespace VirtualMaker.Bindings.Netcode
{
    public partial class Bindings
    {
        public void Bind<T>(NetworkProperty<T> networkVariable, Property<T> prop) where T : unmanaged
            => Bind(networkVariable, value => prop.Value = value);

        public void Bind<T>(NetworkProperty<T> networkVariable, Action action) where T : unmanaged
        {
            action();
            BindDeferred(networkVariable, action);
        }

        public void Bind<T>(NetworkProperty<T> networkVariable, Action<T> action) where T : unmanaged
        {
            action(networkVariable.Value);
            BindDeferred(networkVariable, action);
        }

        public void BindDeferred<T>(NetworkProperty<T> networkVariable, Action<T> action) where T : unmanaged
        {
            networkVariable.OnChange += action;
            AddUnsubscriber(() => networkVariable.OnChange -= action);
        }
    }
}
#endif // UNITY_NETCODE_GAMEOBJECTS
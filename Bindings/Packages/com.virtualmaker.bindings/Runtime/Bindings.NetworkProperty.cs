#if UNITY_NETCODE_GAMEOBJECTS
using System;

namespace VirtualMaker.Bindings.Netcode
{
    public static class BindingsNetcodeExtensions
    {
        public static void Bind<T>(this Bindings bindings, NetworkProperty<T> networkVariable, Property<T> prop) where T : unmanaged
            => bindings.Bind(networkVariable, value => prop.Value = value);

        public static void Bind<T>(this Bindings bindings, NetworkProperty<T> networkVariable, Action action) where T : unmanaged
        {
            action();
            bindings.BindDeferred(networkVariable, action);
        }

        public static void Bind<T>(this Bindings bindings, NetworkProperty<T> networkVariable, Action<T> action) where T : unmanaged
        {
            action(networkVariable.Value);
            bindings.BindDeferred(networkVariable, action);
        }

        public static void BindDeferred<T>(this Bindings bindings, NetworkProperty<T> networkVariable, Action<T> action) where T : unmanaged
        {
            networkVariable.OnChange += action;
            bindings.AddUnsubscriber(() => networkVariable.OnChange -= action);
        }
    }
}
#endif // UNITY_NETCODE_GAMEOBJECTS
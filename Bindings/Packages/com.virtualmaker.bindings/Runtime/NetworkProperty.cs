#if UNITY_NETCODE_GAMEOBJECTS
using System;
using Unity.Netcode;

namespace VirtualMaker.Bindings
{
    [Serializable]
    public class NetworkProperty<T> : NetworkVariable<T>, IProperty<T>, IPropertyNotify where T : unmanaged
    {
        public NetworkProperty(T value, NetworkVariableReadPermission everyone, NetworkVariableWritePermission owner)
            : base(value, everyone, owner)
        {
            OnValueChanged += (oldValue, newValue) =>
            {
                OnChange?.Invoke(newValue);
            };
        }

        ~NetworkProperty() => OnValueChanged = null;

        public void NotifyChanged()
        {
            SetDirty(true);
            OnValueChanged?.Invoke(default, Value);
        }

        public event Action<T> OnChange;
    }
}
#endif // UNITY_NETCODE_GAMEOBJECTS
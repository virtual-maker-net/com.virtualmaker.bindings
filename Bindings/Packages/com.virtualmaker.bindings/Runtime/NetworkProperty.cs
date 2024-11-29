#if UNITY_NETCODE_GAMEOBJECTS
using System;
using Unity.Netcode;
using UnityEngine;

namespace VirtualMaker.Bindings
{
    [Serializable]
    public class NetworkProperty<T> : NetworkVariable<T>, IProperty<T> where T : unmanaged
    {
        public NetworkProperty(T value, NetworkVariableReadPermission everyone, NetworkVariableWritePermission owner)
            : base(value, everyone, owner)
        {
            OnValueChanged += (oldValue, newValue) =>
            {
                Debug.Log($"[NetworkProperty] {oldValue} -> {newValue}");
                OnChange?.Invoke(newValue);
            };
        }

        ~NetworkProperty() => OnValueChanged = null;

        public event Action<T> OnChange;
    }
}
#endif // UNITY_NETCODE_GAMEOBJECTS
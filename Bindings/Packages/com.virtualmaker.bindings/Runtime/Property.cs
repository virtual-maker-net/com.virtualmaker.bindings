using System;
using UnityEngine;

namespace VirtualMaker.Bindings
{
    public interface IPropertyNotify
    {
        void NotifyChanged();
    }

    public interface IProperty<T>
    {
        T Value { get; }
        event Action<T> OnChange;
    }

    [Serializable]
    public class Property<T> : IProperty<T>, IPropertyNotify
    {
        [SerializeField]
        private T _value;
        public T Value
        {
            get => _value;
            set
            {
                if (_value == null || _value.Equals(value))
                {
                    return;
                }

                _value = value;
                OnChange?.Invoke(value);
            }
        }

        public static implicit operator T(Property<T> property)
        {
            if (property != null)
            {
                return property.Value;
            }

            return default;
        }

        public event Action<T> OnChange;

        public void NotifyChanged()
        {
            OnChange?.Invoke(Value);
        }
    }

    public class Derived<W, T> : IProperty<T>
    {
        private IProperty<W> _property;
        private Func<W, T> _getter;

        public T Value => _getter(_property.Value);

        public static implicit operator T(Derived<W, T> derived)
        {
            if (derived != null)
            {
                return derived.Value;
            }

            return default;
        }

        public Derived(IProperty<W> property, Func<W, T> getter)
        {
            _getter = getter;
            _property = property;
            _property.OnChange += (value) => OnChange?.Invoke(Value);
        }

        public event Action<T> OnChange;
    }
}
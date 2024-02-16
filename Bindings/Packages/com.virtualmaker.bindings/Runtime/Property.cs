using System;
using System.Collections.Generic;
using UnityEngine;

namespace VirtualMaker.Bindings
{
    public interface IPropertyNotify
    {
        void NotifyChanged();
    }

    public interface IProperty<TValue>
    {
        TValue Value { get; }
        event Action<TValue> OnChange;
    }

    [Serializable]
    public class Property<TValue> : IProperty<TValue>, IPropertyNotify
    {
        [SerializeField]
        private TValue _value;

        public TValue Value
        {
            get => _value;
            set
            {
                if (EqualityComparer<TValue>.Default.Equals(_value, value))
                {
                    return;
                }

                _value = value;
                OnChange?.Invoke(value);
            }
        }

        public Property()
        {
        }

        public Property(TValue value)
        {
            _value = value;
        }

        public void SetValueWithoutNotify(TValue value)
        {
            _value = value;
        }

        public static implicit operator TValue(Property<TValue> property)
        {
            if (property != null)
            {
                return property.Value;
            }

            return default;
        }

        public event Action<TValue> OnChange;

        public void NotifyChanged() => OnChange?.Invoke(Value);
    }

    public class Derived<TValue, TDerived> : IProperty<TDerived>
    {
        private IProperty<TValue> _property;
        private Func<TValue, TDerived> _func;

        private TDerived _value;
        public TDerived Value => _value;

        public event Action<TDerived> OnChange;

        public static implicit operator TDerived(Derived<TValue, TDerived> derived)
        {
            if (derived != null)
            {
                return derived.Value;
            }

            return default;
        }

        public Derived(IProperty<TValue> property, Func<TValue, TDerived> func)
        {
            _property = property;
            _func = func;
            _property.OnChange += UpdateValue;
            UpdateValue(_property.Value);
        }

        private void UpdateValue(TValue fromValue)
        {
            var newValue = _func(fromValue);
            if (EqualityComparer<TDerived>.Default.Equals(newValue, Value))
            {
                return;
            }

            _value = newValue;
            OnChange?.Invoke(newValue);
        }
    }

    public static class Derived
    {
        public static Derived<TProperty, TValue> From<TProperty, TValue>(IProperty<TProperty> property, Func<TProperty, TValue> getter)
        {
            return new Derived<TProperty, TValue>(property, getter);
        }

        public static Derived<bool, bool> Inverted(this IProperty<bool> property)
        {
            return new Derived<bool, bool>(property, value => !value);
        }
    }
}
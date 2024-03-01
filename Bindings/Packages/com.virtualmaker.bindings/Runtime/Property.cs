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

    public class Derived<TDerived> : IProperty<TDerived>
    {
        private Property<TDerived> _property = new();
        public TDerived Value => _property.Value;
        public event Action<TDerived> OnChange
        {
            add => _property.OnChange += value;
            remove => _property.OnChange -= value;
        }

        public static implicit operator TDerived(Derived<TDerived> derived)
        {
            if (derived != null)
            {
                return derived.Value;
            }

            return default;
        }

        private Derived() { }

        public static Derived<TDerived> From<TValue>(IProperty<TValue> property, Func<TValue, TDerived> func)
        {
            var derived = new Derived<TDerived>();
            Action update = () => derived._property.Value = func(property.Value);
            property.OnChange += _ => update();
            update();
            return derived;
        }

        public static Derived<TDerived> From<TValue1, TValue2>(IProperty<TValue1> property1, IProperty<TValue2> property2, Func<TValue1, TValue2, TDerived> func)
        {
            var derived = new Derived<TDerived>();
            Action update = () => derived._property.Value = func(property1.Value, property2.Value);
            property1.OnChange += _ => update();
            property2.OnChange += _ => update();
            update();
            return derived;
        }

        public static Derived<TDerived> From<TValue1, TValue2, TValue3>(IProperty<TValue1> property1, IProperty<TValue2> property2, IProperty<TValue3> property3, Func<TValue1, TValue2, TValue3, TDerived> func)
        {
            var derived = new Derived<TDerived>();
            Action update = () => derived._property.Value = func(property1.Value, property2.Value, property3.Value);
            property1.OnChange += _ => update();
            property2.OnChange += _ => update();
            property3.OnChange += _ => update();
            update();
            return derived;
        }
    }

    public static class Derived
    {
        public static Derived<TDerived> From<TValue, TDerived>(IProperty<TValue> property, Func<TValue, TDerived> func)
        {
            return Derived<TDerived>.From(property, func);
        }

        public static Derived<TDerived> From<TValue1, TValue2, TDerived>(IProperty<TValue1> property1, IProperty<TValue2> property2, Func<TValue1, TValue2, TDerived> func)
        {
            return Derived<TDerived>.From(property1, property2, func);
        }

        public static Derived<TDerived> From<TValue1, TValue2, TValue3, TDerived>(IProperty<TValue1> property1, IProperty<TValue2> property2, IProperty<TValue3> property3, Func<TValue1, TValue2, TValue3, TDerived> func)
        {
            return Derived<TDerived>.From(property1, property2, property3, func);
        }
    }
}
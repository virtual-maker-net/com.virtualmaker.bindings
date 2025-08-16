using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

namespace VirtualMaker.Bindings
{
    public interface IPropertyNotify
    {
        void NotifyChanged();
    }

    public interface IPropertyChange
    {
        event Action OnChange;
    }

    public interface IProperty<out TValue> : IPropertyChange
    {
        TValue Value { get; }
        event Action<TValue> OnChangeWithValue;
    }

    public interface IPropertySet<TValue> : IProperty<TValue>
    {
        new TValue Value { get; set; }
    }

    [Serializable]
    public class Property<TValue> : IPropertySet<TValue>, IPropertyNotify
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
                NotifyChanged();
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

        public static implicit operator TValue(Property<TValue> prop) => prop._value;

        public event Action<TValue> OnChangeWithValue;
        public event Action OnChange;

        public void NotifyChanged()
        {
            OnChangeWithValue?.Invoke(Value);
            OnChange?.Invoke();
        }

        public void Bind(IProperty<TValue> prop)
            => Bindings2._scope.Bind(prop, this);

        public void Bind(Property<TValue> prop, bool twoWay)
            => Bindings2._scope.Bind(prop, this, twoWay);

        public void Bind<TOther>(IProperty<TOther> prop, Func<TOther, TValue> transform)
            => Bindings2._scope.Bind(prop, this, transform);

        public void BindDeferred(IProperty<TValue> prop)
            => Bindings2._scope.BindDeferred(prop, this);

        public void BindDeferred(Property<TValue> prop, bool twoWay)
            => Bindings2._scope.BindDeferred(prop, this, twoWay);

        public void BindDeferred<TOther>(IProperty<TOther> prop, Func<TOther, TValue> transform)
            => Bindings2._scope.BindDeferred(prop, this, transform);
    }

    [Serializable]
    public class ListProperty<TValue> : List<TValue>, IProperty<List<TValue>>, IPropertyNotify
    {
        public List<TValue> Value => this;

        public event Action<List<TValue>> OnChangeWithValue;
        public event Action OnChange;

        public void NotifyChanged()
        {
            OnChangeWithValue?.Invoke(Value);
            OnChange?.Invoke();
        }
    }

    [Serializable]
    public class DictionaryProperty<TKey, TValue> : Dictionary<TKey, TValue>, IProperty<Dictionary<TKey, TValue>>, IPropertyNotify
    {
        public Dictionary<TKey, TValue> Value => this;

        public event Action<Dictionary<TKey, TValue>> OnChangeWithValue;
        public event Action OnChange;

        public void NotifyChanged()
        {
            OnChangeWithValue?.Invoke(Value);
            OnChange?.Invoke();
        }
    }

    public class Derived<TDerived> : IProperty<TDerived>
    {
        private Property<TDerived> _property = new();
        public TDerived Value => _property.Value;

        public event Action<TDerived> OnChangeWithValue
        {
            add => _property.OnChangeWithValue += value;
            remove => _property.OnChangeWithValue -= value;
        }

        public event Action OnChange
        {
            add => _property.OnChange += value;
            remove => _property.OnChange -= value;
        }

        public static implicit operator TDerived(Derived<TDerived> derived) => derived.Value;

        private Derived() { }

        public static Derived<TDerived> From<TValue>(IProperty<TValue> property, Func<TValue, IProperty<TDerived>> func)
        {
            var derived = new Derived<TDerived>();

            IProperty<TDerived> fromProperty = null;

            void Update()
            {
                derived._property.Value = fromProperty != null ? fromProperty.Value : default;
            }

            void Rebind()
            {
                if (fromProperty != null)
                {
                    fromProperty.OnChange -= Update;
                }

                fromProperty = property.Value != null ? func(property.Value) : null;

                if (fromProperty != null)
                {
                    fromProperty.OnChange += Update;
                }

                Update();
            }

            property.OnChange += Rebind;

            Rebind();

            return derived;
        }

        public static Derived<TDerived> From<TValue>(IProperty<TValue> property, Func<TValue, TDerived> func)
        {
            var derived = new Derived<TDerived>();

            void Update()
            {
                derived._property.Value = func(property.Value);
            }

            property.OnChange += Update;

            Update();

            return derived;
        }

        public static Derived<TDerived> From<TValue1, TValue2>(
            IProperty<TValue1> property1,
            IProperty<TValue2> property2,
            Func<TValue1, TValue2, TDerived> func
        )
        {
            var derived = new Derived<TDerived>();

            void Update()
            {
                derived._property.Value = func(property1.Value, property2.Value);
            }

            property1.OnChange += Update;
            property2.OnChange += Update;

            Update();

            return derived;
        }

        public static Derived<TDerived> From<TValue1, TValue2, TValue3>(
            IProperty<TValue1> property1,
            IProperty<TValue2> property2,
            IProperty<TValue3> property3,
            Func<TValue1, TValue2, TValue3, TDerived> func
        )
        {
            var derived = new Derived<TDerived>();

            void Update()
            {
                derived._property.Value = func(property1.Value, property2.Value, property3.Value);
            }

            property1.OnChange += Update;
            property2.OnChange += Update;
            property3.OnChange += Update;

            Update();

            return derived;
        }

        public static Derived<TDerived> From<TValue1, TValue2, TValue3, TValue4>(
            IProperty<TValue1> property1,
            IProperty<TValue2> property2,
            IProperty<TValue3> property3,
            IProperty<TValue4> property4,
            Func<TValue1, TValue2, TValue3, TValue4, TDerived> func
        )
        {
            var derived = new Derived<TDerived>();

            void Update()
            {
                derived._property.Value = func(property1.Value, property2.Value, property3.Value, property4.Value);
            }

            property1.OnChange += Update;
            property2.OnChange += Update;
            property3.OnChange += Update;
            property4.OnChange += Update;

            Update();

            return derived;
        }
    }

    public static class Derived
    {
        public static Derived<TDerived> From<TValue, TDerived>(IProperty<TValue> property, Func<TValue, Property<TDerived>> func)
        {
            return Derived<TDerived>.From(property, func);
        }

        public static Derived<TDerived> From<TValue, TDerived>(IProperty<TValue> property, Func<TValue, IProperty<TDerived>> func)
        {
            return Derived<TDerived>.From(property, func);
        }

        public static Derived<TDerived> From<TValue, TDerived>(IProperty<TValue> property, Func<TValue, TDerived> func)
        {
            return Derived<TDerived>.From(property, func);
        }

        public static Derived<TDerived> From<TValue1, TValue2, TDerived>(
            IProperty<TValue1> property1,
            IProperty<TValue2> property2,
            Func<TValue1, TValue2, TDerived> func)
        {
            return Derived<TDerived>.From(property1, property2, func);
        }

        public static Derived<TDerived> From<TValue1, TValue2, TValue3, TDerived>(
            IProperty<TValue1> property1,
            IProperty<TValue2> property2,
            IProperty<TValue3> property3,
            Func<TValue1, TValue2, TValue3, TDerived> func)
        {
            return Derived<TDerived>.From(property1, property2, property3, func);
        }

        public static Derived<TDerived> From<TValue1, TValue2, TValue3, TValue4, TDerived>(
            IProperty<TValue1> property1,
            IProperty<TValue2> property2,
            IProperty<TValue3> property3,
            IProperty<TValue4> property4,
            Func<TValue1, TValue2, TValue3, TValue4, TDerived> func)
        {
            return Derived<TDerived>.From(property1, property2, property3, property4, func);
        }

        public static IProperty<bool> All(params IProperty<bool>[] properties)
        {
            var result = new Property<bool>();

            void Update()
            {
                result.Value = properties.All(p => p.Value);
            }

            foreach (var prop in properties)
            {
                prop.OnChange += Update;
            }

            Update();
            return result;
        }

        public static IProperty<bool> Any(params IProperty<bool>[] properties)
        {
            var result = new Property<bool>();

            void Update()
            {
                result.Value = properties.Any(p => p.Value);
            }

            foreach (var prop in properties)
            {
                prop.OnChange += Update;
            }

            Update();
            return result;
        }

        public static Derived<bool> Inverted(this IProperty<bool> property)
        {
            return Derived<bool>.From(property, value => !value);
        }

        public static Derived<bool> IsNotNull<TValue>(this IProperty<TValue> property) where TValue : class
        {
            return Derived<bool>.From(property, value => value != null);
        }

        public static Derived<bool> IsNull<TValue>(this IProperty<TValue> property) where TValue : class
        {
            return Derived<bool>.From(property, value => value == null);
        }

        public static Derived<bool> Is<TValue>(this IProperty<TValue> property, TValue value)
        {
            return Derived<bool>.From(property, v => EqualityComparer<TValue>.Default.Equals(v, value));
        }

        public static Derived<bool> IsNot<TValue>(this IProperty<TValue> property, TValue value)
        {
            return Derived<bool>.From(property, v => !EqualityComparer<TValue>.Default.Equals(v, value));
        }
    }

    public class DerivedProperty<TDerived> : IProperty<TDerived>
    {
        private IProperty<TDerived> _derived;

        private Property<TDerived> _property = new();
        public TDerived Value => _property.Value;

        public event Action<TDerived> OnChangeWithValue
        {
            add => _property.OnChangeWithValue += value;
            remove => _property.OnChangeWithValue -= value;
        }

        public event Action OnChange
        {
            add => _property.OnChange += value;
            remove => _property.OnChange -= value;
        }

        private void SetDerived(IProperty<TDerived> derived)
        {
            if (_derived != null)
            {
                _derived.OnChangeWithValue -= OnDerivedChanged;
            }

            _derived = derived;

            if (_derived != null)
            {
                _derived.OnChangeWithValue += OnDerivedChanged;
                OnDerivedChanged(_derived.Value);
            }
            else
            {
                OnDerivedChanged(default);
            }
        }

        private void OnDerivedChanged(TDerived derived)
        {
            _property.Value = derived;
        }

        private DerivedProperty() { }

        public static DerivedProperty<TDerived> From<TValue>(IProperty<TValue> property, Func<TValue, IProperty<TDerived>> func)
        {
            var derivedProperty = new DerivedProperty<TDerived>();

            void Update()
            {
                derivedProperty.SetDerived(func(property.Value));
            }

            property.OnChangeWithValue += _ => Update();

            Update();

            return derivedProperty;
        }
    }

    public static class DerivedProperty
    {
        public static DerivedProperty<TDerived> From<TValue, TDerived>(IProperty<TValue> property, Func<TValue, IProperty<TDerived>> func)
        {
            return DerivedProperty<TDerived>.From<TValue>(property, func);
        }
    }
}
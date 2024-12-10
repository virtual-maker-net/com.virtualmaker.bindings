using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace VirtualMaker.Bindings
{
    public interface IPropertyNotify
    {
        void NotifyChanged();
    }

    public interface IProperty<out TValue>
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

        private Derived() { }

        public static Derived<TDerived> From<TValue>(IProperty<TValue> property, Func<TValue, TDerived> func)
        {
            var derived = new Derived<TDerived>();

            void Update()
            {
                derived._property.Value = func(property.Value);
            }

            property.OnChange += _ => Update();

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

            property1.OnChange += _ => Update();
            property2.OnChange += _ => Update();

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

            property1.OnChange += _ => Update();
            property2.OnChange += _ => Update();
            property3.OnChange += _ => Update();

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

            property1.OnChange += _ => Update();
            property2.OnChange += _ => Update();
            property3.OnChange += _ => Update();
            property4.OnChange += _ => Update();

            Update();

            return derived;
        }
    }

    public static class Derived
    {
        public static Derived<TDerived> From<TValue, TDerived>(IProperty<TValue> property, Func<TValue, TDerived> func)
        {
            return Derived<TDerived>.From(property, func);
        }

        public static Derived<TDerived> From<TValue1, TValue2, TDerived>(
            IProperty<TValue1> property1,
            IProperty<TValue2> property2,
            Func<TValue1, TValue2, TDerived> func
        )
        {
            return Derived<TDerived>.From(property1, property2, func);
        }

        public static Derived<TDerived> From<TValue1, TValue2, TValue3, TDerived>(
            IProperty<TValue1> property1,
            IProperty<TValue2> property2,
            IProperty<TValue3> property3,
            Func<TValue1, TValue2, TValue3, TDerived> func
        )
        {
            return Derived<TDerived>.From(property1, property2, property3, func);
        }

        public static Derived<TDerived> From<TValue1, TValue2, TValue3, TValue4, TDerived>(
            IProperty<TValue1> property1,
            IProperty<TValue2> property2,
            IProperty<TValue3> property3,
            IProperty<TValue4> property4,
            Func<TValue1, TValue2, TValue3, TValue4, TDerived> func
        )
        {
            return Derived<TDerived>.From(property1, property2, property3, property4, func);
        }

        public static Derived<bool> Inverted(this IProperty<bool> property)
        {
            return Derived<bool>.From(property, value => !value);
        }
    }

    public class DerivedProperty<TDerived> : IProperty<TDerived>
    {
        private IProperty<TDerived> _derived;

        private Property<TDerived> _property = new();
        public TDerived Value => _property.Value;
        public event Action<TDerived> OnChange
        {
            add => _property.OnChange += value;
            remove => _property.OnChange -= value;
        }

        private void SetDerived(IProperty<TDerived> derived)
        {
            if (_derived != null)
            {
                _derived.OnChange -= OnDerivedChanged;
            }

            _derived = derived;

            if (_derived != null)
            {
                _derived.OnChange += OnDerivedChanged;
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

            property.OnChange += _ => Update();

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

    public static class IPropertyAwaitingExtensions
    {
        public static async Task WaitUntilAsync<T>(this IProperty<T> prop, Func<T, bool> predicate, CancellationToken cancellationToken = default)
        {
            var tcs = new TaskCompletionSource<object>();

            prop.OnChange += CheckForDone;
            CheckForDone(prop.Value);

            await tcs.Task;

            void CheckForDone(T value)
            {
                if (predicate(value))
                {
                    prop.OnChange -= CheckForDone;
                    tcs.SetResult(null);
                }
            }
        }
    }
}
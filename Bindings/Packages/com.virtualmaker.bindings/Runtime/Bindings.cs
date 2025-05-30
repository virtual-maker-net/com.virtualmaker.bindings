using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine.Events;

namespace VirtualMaker.Bindings
{
    public partial class Bindings
    {
        public Bindings() { }

        ~Bindings() => Reset();

        private readonly List<Action> _unsubscribe = new List<Action>();

        public void Bind<T>(IProperty<T> prop, Action<T> action)
        {
            BindDeferred(prop, action);
            action(prop.Value);
        }

        public void Bind<T>(IProperty<T> prop, Action action)
        {
            BindDeferred(prop, action);
            action();
        }

        public void Bind<T>(Property<T> prop, Property<T> prop2, bool twoWay)
        {
            Bind(prop, v => prop2.Value = v);

            if (twoWay)
            {
                BindDeferred(prop2, v => prop.Value = v);
            }
        }

        public void BindDeferred<T>(IProperty<T> prop, Action<T> action)
        {
            prop.OnChange += action;
            _unsubscribe.Add(() => prop.OnChange -= action);
        }

        public void BindDeferred<T>(IProperty<T> prop, Action action)
        {
            var wrapper = new Action<T>(_ => action());
            prop.OnChange += wrapper;
            _unsubscribe.Add(() => prop.OnChange -= wrapper);
        }

        public void BindDeferred<T>(Property<T> prop, Property<T> prop2, bool twoWay)
        {
            BindDeferred(prop, v => prop2.Value = v);

            if (twoWay)
            {
                BindDeferred(prop2, v => prop.Value = v);
            }
        }

        public void On(UnityEvent evt, Func<Task> action)
        {
            var wrapper = new UnityAction(async () => await action());
            evt.AddListener(wrapper);
            _unsubscribe.Add(() => evt.RemoveListener(wrapper));
        }

        public void On(UnityEvent evt, UnityAction action)
        {
            evt.AddListener(action);
            _unsubscribe.Add(() => evt.RemoveListener(action));
        }

        public void On<T>(UnityEvent<T> evt, Func<T, Task> action)
        {
            var wrapper = new UnityAction<T>(async v => await action(v));
            evt.AddListener(wrapper);
            _unsubscribe.Add(() => evt.RemoveListener(wrapper));
        }

        public void On<T>(UnityEvent<T> evt, UnityAction<T> action)
        {
            evt.AddListener(action);
            _unsubscribe.Add(() => evt.RemoveListener(action));
        }

        public void On<T0, T1>(UnityEvent<T0, T1> evt, Func<T0, T1, Task> action)
        {
            var wrapper = new UnityAction<T0, T1>(async (v0, v1) => await action(v0, v1));
            evt.AddListener(wrapper);
            _unsubscribe.Add(() => evt.RemoveListener(wrapper));
        }

        public void On<T0, T1>(UnityEvent<T0, T1> evt, UnityAction<T0, T1> action)
        {
            evt.AddListener(action);
            _unsubscribe.Add(() => evt.RemoveListener(action));
        }

        public void On<T0, T1, T2>(UnityEvent<T0, T1, T2> evt, Func<T0, T1, T2, Task> action)
        {
            var wrapper = new UnityAction<T0, T1, T2>(async (v0, v1, v2) => await action(v0, v1, v2));
            evt.AddListener(wrapper);
            _unsubscribe.Add(() => evt.RemoveListener(wrapper));
        }

        public void On<T0, T1, T2>(UnityEvent<T0, T1, T2> evt, UnityAction<T0, T1, T2> action)
        {
            evt.AddListener(action);
            _unsubscribe.Add(() => evt.RemoveListener(action));
        }

        public void On<T0, T1, T2, T3>(UnityEvent<T0, T1, T2, T3> evt, Func<T0, T1, T2, T3, Task> action)
        {
            var wrapper = new UnityAction<T0, T1, T2, T3>(async (v0, v1, v2, v3) => await action(v0, v1, v2, v3));
            evt.AddListener(wrapper);
            _unsubscribe.Add(() => evt.RemoveListener(wrapper));
        }

        public void On<T0, T1, T2, T3>(UnityEvent<T0, T1, T2, T3> evt, UnityAction<T0, T1, T2, T3> action)
        {
            evt.AddListener(action);
            _unsubscribe.Add(() => evt.RemoveListener(action));
        }

        public void On<TObj>(TObj obj, string eventName, Action action) where TObj : class
            => OnDelegate(obj, eventName, action);

        public void On<TObj, T>(TObj obj, string eventName, Action<T> action) where TObj : class
            => OnDelegate(obj, eventName, action);

        public void On<TObj, T0, T1>(TObj obj, string eventName, Action<T0, T1> action) where TObj : class
            => OnDelegate(obj, eventName, action);

        public void On<TObj, T0, T1, T2>(TObj obj, string eventName, Action<T0, T1, T2> action) where TObj : class
            => OnDelegate(obj, eventName, action);

        public void On<TObj, T0, T1, T2, T3>(TObj obj, string eventName, Action<T0, T1, T2, T3> action) where TObj : class
            => OnDelegate(obj, eventName, action);

        public void OnDelegate<TObj>(TObj obj, string eventName, Delegate action) where TObj : class
        {
            var evtInfo = typeof(TObj).GetEvent(eventName);

            if (evtInfo == null)
            {
                throw new InvalidOperationException($"Event \"{eventName}\" not found in {obj.GetType()}");
            }

            var addInfo = evtInfo.GetAddMethod();

            if (addInfo == null)
            {
                throw new InvalidOperationException($"No add method found for event \"{eventName}\"");
            }

            var removeInfo = evtInfo.GetRemoveMethod();

            if (removeInfo == null)
            {
                throw new InvalidOperationException($"No remove method found for event \"{eventName}\"");
            }

            var args = new object[] { action };
            addInfo.Invoke(obj, args);

            AddUnsubscriber(() => removeInfo.Invoke(obj, args));
        }

        public void AddUnsubscriber(Action unsubscribe)
        {
            _unsubscribe.Add(unsubscribe);
        }

        public void Reset()
        {
            foreach (var unsubscribe in _unsubscribe)
            {
                unsubscribe();
            }

            _unsubscribe.Clear();
        }
    }
}
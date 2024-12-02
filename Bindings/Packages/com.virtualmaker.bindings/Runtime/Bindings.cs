using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace VirtualMaker.Bindings
{
    public partial class Bindings
    {
        private List<Action> _unsubscribe = new List<Action>();

        public Bindings()
        {
        }

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

        public void On(UnityEvent evt, UnityAction action)
        {
            evt.AddListener(action);
            _unsubscribe.Add(() => evt.RemoveListener(action));
        }

        public void On<T>(UnityEvent<T> evt, UnityAction<T> action)
        {
            evt.AddListener(action);
            _unsubscribe.Add(() => evt.RemoveListener(action));
        }

        public void On(UnityEvent evt, Func<Task> action)
        {
            UnityAction actionCatcher = async () =>
            {
                try
                {
                    await action();
                }
                catch (Exception e)
                {
                    Debug.LogException(e);
                }
            };

            On(evt, actionCatcher);
        }

        public void On<T>(UnityEvent<T> evt, Func<T, Task> action)
        {
            UnityAction<T> actionCatcher = async (value) =>
            {
                try
                {
                    await action(value);
                }
                catch (Exception e)
                {
                    Debug.LogException(e);
                }
            };

            On(evt, actionCatcher);
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
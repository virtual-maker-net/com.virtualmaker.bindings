using System;
using System.Collections.Generic;

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
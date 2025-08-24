using System;

namespace VirtualMaker.Bindings
{
    public class BindableEvent
    {
        private event Action _evt;

        public void AddListener(Action action)
        {
            _evt += action;
        }

        public void RemoveListener(Action action)
        {
            _evt -= action;
        }

        public void Invoke()
        {
            _evt?.Invoke();
        }

        public void Bind(Action action)
        {
            Bindings2._scope.Bind(this, action);
        }
    }

    public class BindableEvent<T>
    {
        private event Action<T> _evt;

        public void AddListener(Action<T> action)
        {
            _evt += action;
        }

        public void RemoveListener(Action<T> action)
        {
            _evt -= action;
        }

        public void Invoke(T value)
        {
            _evt?.Invoke(value);
        }

        public void Bind(Action<T> action)
        {
            Bindings2._scope.Bind(this, action);
        }
    }

    public class BindableEvent<T1, T2>
    {
        private event Action<T1, T2> _evt;

        public void AddListener(Action<T1, T2> action)
        {
            _evt += action;
        }

        public void RemoveListener(Action<T1, T2> action)
        {
            _evt -= action;
        }

        public void Invoke(T1 value1, T2 value2)
        {
            _evt?.Invoke(value1, value2);
        }

        public void Bind(Action<T1, T2> action)
        {
            Bindings2._scope.Bind(this, action);
        }
    }
}
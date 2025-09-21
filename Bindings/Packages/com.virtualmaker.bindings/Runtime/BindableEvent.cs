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
    }

    public class BindableEvent<T0, T1>
    {
        private event Action<T0, T1> _evt;

        public void AddListener(Action<T0, T1> action)
        {
            _evt += action;
        }

        public void RemoveListener(Action<T0, T1> action)
        {
            _evt -= action;
        }

        public void Invoke(T0 value1, T1 value2)
        {
            _evt?.Invoke(value1, value2);
        }
    }
}
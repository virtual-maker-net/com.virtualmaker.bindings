using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace VirtualMaker.Bindings
{
    public class Bindings2
    {
        private UnityEngine.Object _context;
        private readonly List<Action> _unsubscribers = new List<Action>();

        public Bindings2(UnityEngine.Object context) => _context = context;
        ~Bindings2() => Reset();

        public bool IsValid
        {
            get
            {
                if (!_context)
                {
                    return false;
                }

                if (_context is MonoBehaviour monoBehaviour)
                {
                    return monoBehaviour.isActiveAndEnabled;
                }

                if (_context is Component component)
                {
                    return component.gameObject.activeInHierarchy;
                }

                if (_context is GameObject gameObject)
                {
                    return gameObject.activeInHierarchy;
                }

                return true;
            }
        }

        private Action Wrap(Action action)
            => new Action(() => { if (IsValid) { action(); } });

        private Action<T> Wrap<T>(Action<T> action)
            => new Action<T>(v => { if (IsValid) { action(v); } });

        private Action<T> WrapDiscard<T>(Action action)
            => new Action<T>(_ => { if (IsValid) { action(); } });

        private UnityAction Wrap(UnityAction action)
            => new UnityAction(() => { if (IsValid) { action(); } });

        private UnityAction Wrap(Func<Task> action)
            => new UnityAction(async () => { if (IsValid) { await action(); } });

        private UnityAction<T> Wrap<T>(UnityAction<T> action)
            => new UnityAction<T>(v => { if (IsValid) { action(v); } });

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
            var wrapper = Wrap(action);
            prop.OnChange += wrapper;
            _unsubscribers.Add(() => prop.OnChange -= wrapper);
        }

        public void BindDeferred<T>(IProperty<T> prop, Action action)
        {
            var wrapper = new Action<T>(_ => { if (IsValid) { action(); } });
            prop.OnChange += wrapper;
            _unsubscribers.Add(() => prop.OnChange -= wrapper);
        }

        public void BindDeferred<T>(Property<T> prop, Property<T> prop2, bool twoWay)
        {
            BindDeferred(prop, v => prop2.Value = v);

            if (twoWay)
            {
                BindDeferred(prop2, v => prop.Value = v);
            }
        }

        public void Bind(UnityEvent evt, Func<Task> action)
        {
            var wrapper = Wrap(action);
            evt.AddListener(wrapper);
            _unsubscribers.Add(() => evt.RemoveListener(wrapper));
        }

        public void Bind(UnityEvent evt, UnityAction action)
        {
            var wrapper = Wrap(action);
            evt.AddListener(wrapper);
            _unsubscribers.Add(() => evt.RemoveListener(wrapper));
        }

        public void Bind<T>(UnityEvent<T> evt, UnityAction<T> action)
        {
            var wrapper = Wrap(action);
            evt.AddListener(wrapper);
            _unsubscribers.Add(() => evt.RemoveListener(wrapper));
        }

        internal class PropertyUpdater
        {
            private Action _updateFunc;
            private Func<bool> _doneFunc;
            private bool _cancelled;
            private Func<Awaitable> _awaitableFunc;

            private Task _task;
            public Task Task => _task;

            public PropertyUpdater(Action updateFunc, Func<Awaitable> awaitableFunc, Func<bool> doneFunc = null)
            {
                _updateFunc = updateFunc;
                _doneFunc = doneFunc;
                _awaitableFunc = awaitableFunc;
                _task = RunAsync();
            }

            public void Reset()
            {
                _cancelled = true;
            }

            private async Task RunAsync()
            {
                while (!_cancelled && (_doneFunc == null || !_doneFunc()))
                {
                    _updateFunc();
                    await _awaitableFunc();
                }
            }
        }

        public void BindUpdate(Action updateFunc, Func<bool> doneFunc = null)
        {
            var updater = new PropertyUpdater(updateFunc, () => Awaitable.NextFrameAsync(), doneFunc);
            _unsubscribers.Add(() => updater.Reset());
        }

        public void BindLateUpdate(Action updateFunc, Func<bool> doneFunc = null)
        {
            var updater = new PropertyUpdater(updateFunc, () => Awaitable.EndOfFrameAsync(), doneFunc);
            _unsubscribers.Add(() => updater.Reset());
        }

        public void BindInterval(float seconds, Action updateFunc, Func<bool> doneFunc = null)
        {
            var updater = new PropertyUpdater(updateFunc, () => Awaitable.WaitForSecondsAsync(seconds), doneFunc);
            _unsubscribers.Add(() => updater.Reset());
        }

        public void Animate(AnimationCurve curve, Action<float> action)
        {
            var startTime = Time.time;
            var updater = new PropertyUpdater(
                () => action(curve.Evaluate(Time.time - startTime)),
                () => Awaitable.NextFrameAsync(),
                () => Time.time - startTime >= curve.keys[^1].time);
        }

        public void AddUnsubscriber(Action unsubscribe)
        {
            _unsubscribers.Add(unsubscribe);
        }

        public void Reset()
        {
            foreach (var unsubscribe in _unsubscribers)
            {
                unsubscribe();
            }

            _unsubscribers.Clear();
        }
    }
}
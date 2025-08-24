using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace VirtualMaker.Bindings
{
    public class BindingsScope : IDisposable
    {
        private Bindings2 _bindings;
        public BindingsScope(Bindings2 bindings)
        {
            _bindings = bindings;
            Bindings2._scopes.Add(_bindings);
        }

        public void Dispose()
        {
            Bindings2._scopes.Remove(_bindings);
        }
    }

    public class Bindings2
    {
        internal static List<Bindings2> _scopes = new();
        internal static Bindings2 _scope => _scopes[^1];
        private readonly List<Action> _unsubscribers = new List<Action>();
        private CancellationTokenSource _cts = new();

        public Bindings2()
        {
            _unsubscribers.Add(() => _cts.Cancel());
        }

        ~Bindings2() => Clear();

        public BindingsScope Scope() => new BindingsScope(this);

        public void Bind<T>(IProperty<T> prop, Action<T> action)
        {
            BindDeferred(prop, action);
            action(prop.Value);
        }

        public void Bind(IPropertyChange prop, Action action)
        {
            BindDeferred(prop, action);
            action();
        }

        public void Bind(Action action, params IPropertyChange[] props)
        {
            BindDeferred(action, props);
            action();
        }

        public void Bind<T>(IProperty<T> prop, IPropertySet<T> prop2)
        {
            Bind(prop, v => prop2.Value = v);
        }

        public void Bind<T1, T2>(IProperty<T1> prop, IPropertySet<T2> prop2, Func<T1, T2> transform)
        {
            Bind(prop, v => prop2.Value = transform(v));
        }

        public void Bind<T>(Property<T> prop, IPropertySet<T> prop2, bool twoWay)
        {
            Bind(prop, v => prop2.Value = v);

            if (twoWay)
            {
                BindDeferred(prop2, v => prop.Value = v);
            }
        }

        public void BindDeferred<T>(IProperty<T> prop, Action<T> action)
        {
            prop.OnChangeWithValue += action;
            _unsubscribers.Add(() => prop.OnChangeWithValue -= action);
        }

        public void BindDeferred(IPropertyChange prop, Action action)
        {
            var wrapper = new Action(() => action());
            prop.OnChange += wrapper;
            _unsubscribers.Add(() => prop.OnChange -= wrapper);
        }

        public void BindDeferred(Action action, params IPropertyChange[] props)
        {
            foreach (var prop in props)
            {
                BindDeferred(prop, action);
            }
        }

        public void BindDeferred<T>(IProperty<T> prop, IPropertySet<T> prop2)
        {
            BindDeferred(prop, v => prop2.Value = v);
        }

        public void BindDeferred<T1, T2>(IProperty<T1> prop, IPropertySet<T2> prop2, Func<T1, T2> transform)
        {
            BindDeferred(prop, v => prop2.Value = transform(v));
        }

        public void BindDeferred<T>(IPropertySet<T> prop, IPropertySet<T> prop2, bool twoWay)
        {
            BindDeferred(prop, v => prop2.Value = v);

            if (twoWay)
            {
                BindDeferred(prop2, v => prop.Value = v);
            }
        }

        public void Bind(BindableEvent evt, Func<Task> action)
        {
            var wrapper = new Action(async () => await action());
            evt.AddListener(wrapper);
            _unsubscribers.Add(() => evt.RemoveListener(wrapper));
        }

        public void Bind<T>(BindableEvent<T> evt, Func<T, Task> action)
        {
            var wrapper = new Action<T>(async (v) => await action(v));
            evt.AddListener(wrapper);
            _unsubscribers.Add(() => evt.RemoveListener(wrapper));
        }

        public void Bind<T1, T2>(BindableEvent<T1, T2> evt, Func<T1, T2, Task> action)
        {
            var wrapper = new Action<T1, T2>(async (v1, v2) => await action(v1, v2));
            evt.AddListener(wrapper);
            _unsubscribers.Add(() => evt.RemoveListener(wrapper));
        }

        public void Bind(UnityEvent evt, Func<Task> action)
        {
            var wrapper = new UnityAction(async () => await action());
            evt.AddListener(wrapper);
            _unsubscribers.Add(() => evt.RemoveListener(wrapper));
        }

        public void Bind(BindableEvent evt, Action action)
        {
            evt.AddListener(action);
            _unsubscribers.Add(() => evt.RemoveListener(action));
        }

        public void Bind<T>(BindableEvent<T> evt, Action<T> action)
        {
            evt.AddListener(action);
            _unsubscribers.Add(() => evt.RemoveListener(action));
        }

        public void Bind<T1, T2>(BindableEvent<T1, T2> evt, Action<T1, T2> action)
        {
            evt.AddListener(action);
            _unsubscribers.Add(() => evt.RemoveListener(action));
        }

        public void Bind(UnityEvent evt, UnityAction action)
        {
            evt.AddListener(action);
            _unsubscribers.Add(() => evt.RemoveListener(action));
        }

        public void Bind<T>(UnityEvent<T> evt, Func<T, Task> action)
        {
            var wrapper = new UnityAction<T>(async v => await action(v));
            evt.AddListener(wrapper);
            _unsubscribers.Add(() => evt.RemoveListener(wrapper));
        }

        public void Bind<T>(UnityEvent<T> evt, UnityAction<T> action)
        {
            evt.AddListener(action);
            _unsubscribers.Add(() => evt.RemoveListener(action));
        }

        public void Bind<T0, T1>(UnityEvent<T0, T1> evt, Func<T0, T1, Task> action)
        {
            var wrapper = new UnityAction<T0, T1>(async (v0, v1) => await action(v0, v1));
            evt.AddListener(wrapper);
            _unsubscribers.Add(() => evt.RemoveListener(wrapper));
        }

        public void Bind<T0, T1>(UnityEvent<T0, T1> evt, UnityAction<T0, T1> action)
        {
            evt.AddListener(action);
            _unsubscribers.Add(() => evt.RemoveListener(action));
        }

        public void Bind<T0, T1, T2>(UnityEvent<T0, T1, T2> evt, Func<T0, T1, T2, Task> action)
        {
            var wrapper = new UnityAction<T0, T1, T2>(async (v0, v1, v2) => await action(v0, v1, v2));
            evt.AddListener(wrapper);
            _unsubscribers.Add(() => evt.RemoveListener(wrapper));
        }

        public void Bind<T0, T1, T2>(UnityEvent<T0, T1, T2> evt, UnityAction<T0, T1, T2> action)
        {
            evt.AddListener(action);
            _unsubscribers.Add(() => evt.RemoveListener(action));
        }

        public void Bind<T0, T1, T2, T3>(UnityEvent<T0, T1, T2, T3> evt, Func<T0, T1, T2, T3, Task> action)
        {
            var wrapper = new UnityAction<T0, T1, T2, T3>(async (v0, v1, v2, v3) => await action(v0, v1, v2, v3));
            evt.AddListener(wrapper);
            _unsubscribers.Add(() => evt.RemoveListener(wrapper));
        }

        public void Bind<T0, T1, T2, T3>(UnityEvent<T0, T1, T2, T3> evt, UnityAction<T0, T1, T2, T3> action)
        {
            evt.AddListener(action);
            _unsubscribers.Add(() => evt.RemoveListener(action));
        }

        internal class PropertyUpdater
        {
            private Action _updateFunc;
            private Func<bool> _doneFunc;
            private Func<Awaitable> _awaitableFunc;

            private Task _task;
            public Task Task => _task;

            public PropertyUpdater(
                Action updateFunc,
                Func<Awaitable> awaitableFunc,
                Func<bool> doneFunc,
                CancellationToken cancellationToken)
            {
                _updateFunc = updateFunc;
                _doneFunc = doneFunc;
                _awaitableFunc = awaitableFunc;
                _task = RunAsync(cancellationToken);
            }

            private async Task RunAsync(CancellationToken cancellationToken)
            {
                while (!cancellationToken.IsCancellationRequested && (_doneFunc == null || !_doneFunc()))
                {
                    try
                    {
                        _updateFunc();
                    }
                    catch (Exception e)
                    {
                        Debug.LogException(e);
                    }

                    await _awaitableFunc();
                }
            }
        }

        public void BindUpdate(Action updateFunc, Func<bool> doneFunc = null)
        {
            var updater = new PropertyUpdater(updateFunc, () => Awaitable.NextFrameAsync(), doneFunc, _cts.Token);
        }

        public void BindLateUpdate(Action updateFunc, Func<bool> doneFunc = null)
        {
            var updater = new PropertyUpdater(updateFunc, () => Awaitable.EndOfFrameAsync(), doneFunc, _cts.Token);
        }

        public void BindInterval(float seconds, Action updateFunc, Func<bool> doneFunc = null)
        {
            var updater = new PropertyUpdater(updateFunc, () => Awaitable.WaitForSecondsAsync(seconds), doneFunc, _cts.Token);
        }

        public async void Animate(AnimationCurve curve, Action<float> action, CancellationToken cancellationToken = default)
            => await AnimateAsync(curve, action, cancellationToken);

        public async Task AnimateAsync(
            AnimationCurve curve,
            Action<float> action,
            CancellationToken cancellationToken = default)
        {
            using var cts = CancellationTokenSource.CreateLinkedTokenSource(_cts.Token, cancellationToken);
            var startTime = Time.time;
            var updater = new PropertyUpdater(
                () => action(curve.Evaluate(Time.time - startTime)),
                () => Awaitable.NextFrameAsync(),
                () => Time.time - startTime >= curve.keys[^1].time,
                cts.Token);
            await updater.Task;
        }

        public IProperty<float> CreateTransition(IProperty<bool> prop, AnimationCurve curve)
        {
            Property<float> transition = new(prop.Value ? curve.keys[^1].value : curve.keys[0].value);
            var reverseCurve = Easing.Reverse(curve);

            CancellationTokenSource cancellationTokenSource = null;

            CancellationToken GetCancellationToken()
            {
                cancellationTokenSource?.Cancel();
                cancellationTokenSource?.Dispose();
                cancellationTokenSource = new();
                return cancellationTokenSource.Token;
            }

            BindDeferred(prop, value =>
            {
                Animate(
                    value ? curve : reverseCurve,
                    v => transition.Value = v,
                    GetCancellationToken());
            });

            return transition;
        }

        public void AddUnsubscriber(Action unsubscribe)
        {
            _unsubscribers.Add(unsubscribe);
        }

        public async Task WaitUntilAsync(IProperty<bool> prop)
        {
            var tcs = new TaskCompletionSource<bool>();

            void Unsubscribe()
            {
                prop.OnChangeWithValue -= Update;
            }

            void Update(bool value)
            {
                if (value)
                {
                    tcs.SetResult(true);
                    prop.OnChangeWithValue -= Update;
                    _unsubscribers.Remove(Unsubscribe);
                }
            }

            prop.OnChangeWithValue += Update;
            AddUnsubscriber(Unsubscribe);
            await tcs.Task;
        }

        public void Clear()
        {
            foreach (var unsubscribe in _unsubscribers)
            {
                unsubscribe();
            }

            _unsubscribers.Clear();
        }
    }
}
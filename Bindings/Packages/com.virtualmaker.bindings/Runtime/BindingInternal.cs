using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace VirtualMaker.Bindings
{
    internal struct BindingContext
    {
        public bool HasUnityObject;
        public UnityEngine.Object UnityObject;
        public CancellationToken CancellationToken;

        public BindingContext(UnityEngine.Object unityObject, bool hasUnityObject, CancellationToken cancellationToken)
        {
            HasUnityObject = hasUnityObject;
            UnityObject = unityObject;
            CancellationToken = cancellationToken;
        }

        public BindingContext(UnityEngine.Object unityObject, CancellationToken cancellationToken) :
            this(unityObject, true, cancellationToken) {}

        public BindingContext(CancellationToken cancellationToken) :
            this(null, false, cancellationToken) {}

        public readonly bool IsValid
            => !CancellationToken.IsCancellationRequested && (!HasUnityObject || UnityObject);
    }

    internal static class BindingsInternal
    {
        private static void BindAsync(BindingContext context, Action<Action> subscribe, Action<Action> unsubscribe, Func<Task> action)
        {
            async void Update()
            {
                if (context.IsValid)
                {
                    await action();
                }
                else
                {
                    unsubscribe(Update);
                }
            }

            subscribe(Update);
        }

        private static void Bind(BindingContext context, Action<Action> subscribe, Action<Action> unsubscribe, Action action)
        {
            void Update()
            {
                if (context.IsValid)
                {
                    action();
                }
                else
                {
                    unsubscribe(Update);
                }
            }

            subscribe(Update);
        }

        private static void BindAsync<T>(BindingContext context, Action<Action<T>> subscribe, Action<Action<T>> unsubscribe, Func<T, Task> action)
        {
            async void Update(T v)
            {
                if (context.IsValid)
                {
                    await action(v);
                }
                else
                {
                    unsubscribe(Update);
                }
            }

            subscribe(Update);
        }

        private static void Bind<T>(BindingContext context, Action<Action<T>> subscribe, Action<Action<T>> unsubscribe, Action<T> action)
        {
            void Update(T v)
            {
                if (context.IsValid)
                {
                    action(v);
                }
                else
                {
                    unsubscribe(Update);
                }
            }

            subscribe(Update);
        }

        private static void BindAsync<T0, T1>(BindingContext context, Action<Action<T0, T1>> subscribe, Action<Action<T0, T1>> unsubscribe, Func<T0, T1, Task> action)
        {
            async void Update(T0 v0, T1 v1)
            {
                if (context.IsValid)
                {
                    await action(v0, v1);
                }
                else
                {
                    unsubscribe(Update);
                }
            }

            subscribe(Update);
        }

        private static void Bind<T0, T1>(BindingContext context, Action<Action<T0, T1>> subscribe, Action<Action<T0, T1>> unsubscribe, Action<T0, T1> action)
        {
            void Update(T0 v0, T1 v1)
            {
                if (context.IsValid)
                {
                    action(v0, v1);
                }
                else
                {
                    unsubscribe(Update);
                }
            }

            subscribe(Update);
        }

        private static void BindAsync<T0, T1, T2>(BindingContext context, Action<Action<T0, T1, T2>> subscribe, Action<Action<T0, T1, T2>> unsubscribe, Func<T0, T1, T2, Task> action)
        {
            async void Update(T0 v0, T1 v1, T2 v2)
            {
                if (context.IsValid)
                {
                    await action(v0, v1, v2);
                }
                else
                {
                    unsubscribe(Update);
                }
            }

            subscribe(Update);
        }

        private static void Bind<T0, T1, T2>(BindingContext context, Action<Action<T0, T1, T2>> subscribe, Action<Action<T0, T1, T2>> unsubscribe, Action<T0, T1, T2> action)
        {
            void Update(T0 v0, T1 v1, T2 v2)
            {
                if (context.IsValid)
                {
                    action(v0, v1, v2);
                }
                else
                {
                    unsubscribe(Update);
                }
            }

            subscribe(Update);
        }

        private static void BindAsync<T0, T1, T2, T3>(BindingContext context, Action<Action<T0, T1, T2, T3>> subscribe, Action<Action<T0, T1, T2, T3>> unsubscribe, Func<T0, T1, T2, T3, Task> action)
        {
            async void Update(T0 v0, T1 v1, T2 v2, T3 v3)
            {
                if (context.IsValid)
                {
                    await action(v0, v1, v2, v3);
                }
                else
                {
                    unsubscribe(Update);
                }
            }

            subscribe(Update);
        }

        private static void Bind<T0, T1, T2, T3>(BindingContext context, Action<Action<T0, T1, T2, T3>> subscribe, Action<Action<T0, T1, T2, T3>> unsubscribe, Action<T0, T1, T2, T3> action)
        {
            void Update(T0 v0, T1 v1, T2 v2, T3 v3)
            {
                if (context.IsValid)
                {
                    action(v0, v1, v2, v3);
                }
                else
                {
                    unsubscribe(Update);
                }
            }

            subscribe(Update);
        }

        private static void BindUnity(BindingContext context, Action<UnityAction> subscribe, Action<UnityAction> unsubscribe, Func<Task> action)
        {
            async void Update()
            {
                if (context.IsValid)
                {
                    await action();
                }
                else
                {
                    unsubscribe(Update);
                }
            }

            subscribe(Update);
        }

        private static void BindUnity(BindingContext context, Action<UnityAction> subscribe, Action<UnityAction> unsubscribe, Action action)
        {
            void Update()
            {
                if (context.IsValid)
                {
                    action();
                }
                else
                {
                    unsubscribe(Update);
                }
            }

            subscribe(Update);
        }

        private static void BindUnity<T>(BindingContext context, Action<UnityAction<T>> subscribe, Action<UnityAction<T>> unsubscribe, Func<T, Task> action)
        {
            async void Update(T v)
            {
                if (context.IsValid)
                {
                    await action(v);
                }
                else
                {
                    unsubscribe(Update);
                }
            }

            subscribe(Update);
        }

        private static void BindUnity<T>(BindingContext context, Action<UnityAction<T>> subscribe, Action<UnityAction<T>> unsubscribe, Action<T> action)
        {
            void Update(T v)
            {
                if (context.IsValid)
                {
                    action(v);
                }
                else
                {
                    unsubscribe(Update);
                }
            }

            subscribe(Update);
        }

        private static void BindUnity<T0, T1>(BindingContext context, Action<UnityAction<T0, T1>> subscribe, Action<UnityAction<T0, T1>> unsubscribe, Func<T0, T1, Task> action)
        {
            async void Update(T0 v0, T1 v1)
            {
                if (context.IsValid)
                {
                    await action(v0, v1);
                }
                else
                {
                    unsubscribe(Update);
                }
            }

            subscribe(Update);
        }

        private static void BindUnity<T0, T1>(BindingContext context, Action<UnityAction<T0, T1>> subscribe, Action<UnityAction<T0, T1>> unsubscribe, Action<T0, T1> action)
        {
            void Update(T0 v0, T1 v1)
            {
                if (context.IsValid)
                {
                    action(v0, v1);
                }
                else
                {
                    unsubscribe(Update);
                }
            }

            subscribe(Update);
        }

        private static void BindUnity<T0, T1, T2>(BindingContext context, Action<UnityAction<T0, T1, T2>> subscribe, Action<UnityAction<T0, T1, T2>> unsubscribe, Func<T0, T1, T2, Task> action)
        {
            async void Update(T0 v0, T1 v1, T2 v2)
            {
                if (context.IsValid)
                {
                    await action(v0, v1, v2);
                }
                else
                {
                    unsubscribe(Update);
                }
            }

            subscribe(Update);
        }

        private static void BindUnity<T0, T1, T2>(BindingContext context, Action<UnityAction<T0, T1, T2>> subscribe, Action<UnityAction<T0, T1, T2>> unsubscribe, Action<T0, T1, T2> action)
        {
            void Update(T0 v0, T1 v1, T2 v2)
            {
                if (context.IsValid)
                {
                    action(v0, v1, v2);
                }
                else
                {
                    unsubscribe(Update);
                }
            }

            subscribe(Update);
        }

        private static void BindUnity<T0, T1, T2, T3>(BindingContext context, Action<UnityAction<T0, T1, T2, T3>> subscribe, Action<UnityAction<T0, T1, T2, T3>> unsubscribe, Func<T0, T1, T2, T3, Task> action)
        {
            async void Update(T0 v0, T1 v1, T2 v2, T3 v3)
            {
                if (context.IsValid)
                {
                    await action(v0, v1, v2, v3);
                }
                else
                {
                    unsubscribe(Update);
                }
            }

            subscribe(Update);
        }

        private static void BindUnity<T0, T1, T2, T3>(BindingContext context, Action<UnityAction<T0, T1, T2, T3>> subscribe, Action<UnityAction<T0, T1, T2, T3>> unsubscribe, Action<T0, T1, T2, T3> action)
        {
            void Update(T0 v0, T1 v1, T2 v2, T3 v3)
            {
                if (context.IsValid)
                {
                    action(v0, v1, v2, v3);
                }
                else
                {
                    unsubscribe(Update);
                }
            }

            subscribe(Update);
        }

        internal static void BindDeferred<T>(BindingContext context, IProperty<T> property, Action<T> action)
            => Bind(context, a => property.OnChangeWithValue += a, a => property.OnChangeWithValue -= a, action);

        internal static void BindDeferred(BindingContext context, IPropertyChange property, Action action)
            => Bind(context, a => property.OnChange += a, a => property.OnChange -= a, action);

        internal static void BindDeferred<T>(BindingContext context, Property<T> property, Action<T> action)
            => BindDeferred(context, property, action);

        internal static void BindDeferred(BindingContext context, Action action, params IPropertyChange[] props)
        {
            foreach (var prop in props)
            {
                BindDeferred(context, prop, action);
            }
        }

        internal static void BindDeferred<T>(BindingContext context, IProperty<T> prop, IPropertySet<T> prop2)
            => BindDeferred(context, prop, v => prop2.Value = v);

        internal static void BindDeferred<T0, T1>(BindingContext context, IProperty<T0> prop, IPropertySet<T1> prop2, Func<T0, T1> transform)
            => BindDeferred(context, prop, v => prop2.Value = transform(v));

        internal static void BindDeferred<T>(BindingContext context, IPropertySet<T> prop, IPropertySet<T> prop2, bool twoWay)
        {
            BindDeferred(context, prop, v => prop2.Value = v);

            if (twoWay)
            {
                BindDeferred(context, prop2, v => prop.Value = v);
            }
        }

        internal static void Bind<T>(BindingContext context, IProperty<T> prop, Action<T> action)
        {
            BindDeferred(context, prop, action);
            action(prop.Value);
        }

        internal static void Bind(BindingContext context, IPropertyChange prop, Action action)
        {
            BindDeferred(context, prop, action);
            action();
        }

        internal static void Bind(BindingContext context, Action action, params IPropertyChange[] props)
        {
            BindDeferred(context, action, props);
            action();
        }

        internal static void Bind<T>(BindingContext context, IProperty<T> prop, IPropertySet<T> prop2)
        {
            Bind(context, prop, v => prop2.Value = v);
        }

        internal static void Bind<T1, T2>(BindingContext context, IProperty<T1> prop, IPropertySet<T2> prop2, Func<T1, T2> transform)
        {
            Bind(context, prop, v => prop2.Value = transform(v));
        }

        internal static void Bind<T>(BindingContext context, Property<T> prop, IPropertySet<T> prop2, bool twoWay)
        {
            Bind(context, prop, v => prop2.Value = v);

            if (twoWay)
            {
                BindDeferred(context, prop2, v => prop.Value = v);
            }
        }

        internal static void Bind(BindingContext context, BindableEvent evt, Func<Task> action)
            => BindAsync(context, evt.AddListener, evt.RemoveListener, action);

        internal static void Bind<T>(BindingContext context, BindableEvent<T> evt, Func<T, Task> action)
            => BindAsync(context, evt.AddListener, evt.RemoveListener, action);

        internal static void Bind<T0, T1>(BindingContext context, BindableEvent<T0, T1> evt, Func<T0, T1, Task> action)
            => BindAsync(context, evt.AddListener, evt.RemoveListener, action);

        internal static void Bind(BindingContext context, BindableEvent evt, Action action)
            => Bind(context, evt.AddListener, evt.RemoveListener, action);

        internal static void Bind<T>(BindingContext context, BindableEvent<T> evt, Action<T> action)
            => Bind(context, evt.AddListener, evt.RemoveListener, action);

        internal static void Bind<T0, T1>(BindingContext context, BindableEvent<T0, T1> evt, Action<T0, T1> action)
            => Bind(context, evt.AddListener, evt.RemoveListener, action);

        internal static void Bind(BindingContext context, UnityEvent evt, Func<Task> action)
            => BindUnity(context, evt.AddListener, evt.RemoveListener, action);

        internal static void Bind(BindingContext context, UnityEvent evt, Action action)
            => BindUnity(context, evt.AddListener, evt.RemoveListener, action);

        internal static void Bind<T>(BindingContext context, UnityEvent<T> evt, Func<T, Task> action)
            => BindUnity(context, evt.AddListener, evt.RemoveListener, action);

        internal static void Bind<T>(BindingContext context, UnityEvent<T> evt, Action<T> action)
            => BindUnity(context, evt.AddListener, evt.RemoveListener, action);

        internal static void Bind<T0, T1>(BindingContext context, UnityEvent<T0, T1> evt, Func<T0, T1, Task> action)
            => BindUnity(context, evt.AddListener, evt.RemoveListener, action);

        internal static void Bind<T0, T1>(BindingContext context, UnityEvent<T0, T1> evt, Action<T0, T1> action)
            => BindUnity(context, evt.AddListener, evt.RemoveListener, action);

        internal static void Bind<T0, T1, T2>(BindingContext context, UnityEvent<T0, T1, T2> evt, Func<T0, T1, T2, Task> action)
            => BindUnity(context, evt.AddListener, evt.RemoveListener, action);

        internal static void Bind<T0, T1, T2>(BindingContext context, UnityEvent<T0, T1, T2> evt, Action<T0, T1, T2> action)
            => BindUnity(context, evt.AddListener, evt.RemoveListener, action);

        internal static void Bind<T0, T1, T2, T3>(BindingContext context, UnityEvent<T0, T1, T2, T3> evt, Func<T0, T1, T2, T3, Task> action)
            => BindUnity(context, evt.AddListener, evt.RemoveListener, action);

        internal static void Bind<T0, T1, T2, T3>(BindingContext context, UnityEvent<T0, T1, T2, T3> evt, Action<T0, T1, T2, T3> action)
            => BindUnity(context, evt.AddListener, evt.RemoveListener, action);

        internal static void BindUpdate(BindingContext context, Action updateFunc, Func<bool> doneFunc = null)
        {
            new PropertyUpdater(context, updateFunc, () => Awaitable.NextFrameAsync(), doneFunc);
        }

        internal static void BindLateUpdate(BindingContext context, Action updateFunc, Func<bool> doneFunc = null)
        {
            new PropertyUpdater(context, updateFunc, () => Awaitable.EndOfFrameAsync(), doneFunc);
        }

        internal static void BindInterval(BindingContext context, float seconds, Action updateFunc, Func<bool> doneFunc = null)
        {
            new PropertyUpdater(context, updateFunc, () => Awaitable.WaitForSecondsAsync(seconds), doneFunc);
        }

        internal static async void Animate(BindingContext context, AnimationCurve curve, Action<float> action)
            => await AnimateAsync(context, curve, action);

        internal static async Task AnimateAsync(
            BindingContext context,
            AnimationCurve curve,
            Action<float> action,
            CancellationToken cancellationToken = default)
        {
            var startTime = Time.time;
            var updater = new PropertyUpdater(
                context,
                () => action(curve.Evaluate(Time.time - startTime)),
                () => Awaitable.NextFrameAsync(),
                () => Time.time - startTime >= curve.keys[^1].time);
            await updater.Task;
            cancellationToken.ThrowIfCancellationRequested();
        }

        internal static IProperty<float> CreateTransition(BindingContext context, IProperty<bool> prop, AnimationCurve curve)
        {
            Property<float> transition = new(prop.Value ? curve.keys[^1].value : curve.keys[0].value);
            var reverseCurve = Easing.Reverse(curve);

            CancellationTokenSource cancellationTokenSource = null;

            BindingContext CreateAnimationContext()
            {
                cancellationTokenSource?.Cancel();
                cancellationTokenSource?.Dispose();
                cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(context.CancellationToken);
                return new(context.UnityObject, context.HasUnityObject, cancellationTokenSource.Token);
            }

            BindDeferred(context, prop, value =>
            {
                Animate(
                    CreateAnimationContext(),
                    value ? curve : reverseCurve,
                    v => transition.Value = v);
            });

            return transition;
        }

        internal static async Task WaitUntilAsync(BindingContext context, IProperty<bool> prop)
        {
            var tcs = new TaskCompletionSource<bool>(context.CancellationToken);

            void Update(bool value)
            {
                if (context.CancellationToken.IsCancellationRequested)
                {
                    prop.OnChangeWithValue -= Update;
                }
                else if (value)
                {
                    tcs.SetResult(true);
                    prop.OnChangeWithValue -= Update;
                }
            }

            prop.OnChangeWithValue += Update;
            await tcs.Task;
        }
    }
}
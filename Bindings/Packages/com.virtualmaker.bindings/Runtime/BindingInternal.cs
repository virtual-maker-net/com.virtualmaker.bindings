using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace VirtualMaker.Bindings
{
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

        internal static void BindDeferred<T>(BindingContext context, IProperty<T> fromProp, IPropertySet<T> toProp)
            => BindDeferred(context, fromProp, v => toProp.Value = v);

        internal static void BindDeferred<T0, T1>(BindingContext context, IProperty<T0> fromProp, IPropertySet<T1> toProp, Func<T0, T1> transform)
            => BindDeferred(context, fromProp, v => toProp.Value = transform(v));

        internal static void BindDeferred<T>(BindingContext context, IPropertySet<T> fromProp, IPropertySet<T> toProp, bool twoWay)
        {
            BindDeferred(context, fromProp, v => toProp.Value = v);

            if (twoWay)
            {
                BindDeferred(context, toProp, v => fromProp.Value = v);
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

        internal static void Bind<T>(BindingContext context, IProperty<T> fromProp, IPropertySet<T> toProp)
        {
            Bind(context, fromProp, v => toProp.Value = v);
        }

        internal static void Bind<T1, T2>(BindingContext context, IProperty<T1> fromProp, IPropertySet<T2> toProp, Func<T1, T2> transform)
        {
            Bind(context, fromProp, v => toProp.Value = transform(v));
        }

        internal static void Bind<T>(BindingContext context, IPropertySet<T> fromProp, IPropertySet<T> toProp, bool twoWay)
        {
            Bind(context, fromProp, v => toProp.Value = v);

            if (twoWay)
            {
                BindDeferred(context, toProp, v => fromProp.Value = v);
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

        public static IReadOnlyDictionary<TItem, TComponent> BindList<TItem, TComponent>(BindingContext context,
            Transform parent, TComponent prefab, IProperty<List<TItem>> prop, Action<TItem, TComponent> onPrefabAdded,
            Action<TItem, TComponent> onListUpdated = null) where TComponent : Component
        {
            var childItems = new Dictionary<TItem, TComponent>();

            Action<List<TItem>> update = list =>
            {
                // Remove items that are no longer in the list.
                var removed = new List<TItem>();

                foreach (var (fromItem, toItem) in childItems)
                {
                    // In edit mode remove everything, so we can test data changes
                    if (!list.Contains(fromItem) || !Application.isPlaying)
                    {
                        toItem.gameObject.Destroy();
                        removed.Add(fromItem);
                    }
                }

                foreach (var item in removed)
                {
                    childItems.Remove(item);
                }

                // Add items that are new to the list.
                for (int i = 0; i < list.Count; i++)
                {
                    var item = list[i];
                    if (!childItems.TryGetValue(item, out var toItem))
                    {
                        toItem = UnityEngine.Object.Instantiate(prefab, parent);
                        childItems.Add(item, toItem);
                        onPrefabAdded(item, toItem);
                    }

                    toItem.transform.SetSiblingIndex(i);
                }

                if (onListUpdated != null)
                {
                    foreach (var (item, child) in childItems)
                    {
                        onListUpdated(item, child);
                    }
                }
            };

            void Subscribe(Action<List<TItem>> action)
            {
                prop.OnChangeWithValue += action;
            }

            void Unsubscribe(Action<List<TItem>> action)
            {
                prop.OnChangeWithValue -= action;

                foreach (var (_, toItem) in childItems)
                {
                    toItem.gameObject.Destroy();
                }
            }

            Bind(context, Subscribe, Unsubscribe, update);
            update(prop.Value);
            return childItems;
        }

        public static IReadOnlyDictionary<TKey, TComponent> BindDictionary<TKey, TValue, TComponent>(
            BindingContext context, Transform parent, TComponent prefab, IProperty<Dictionary<TKey, TValue>> prop,
            Action<TKey, TValue, TComponent> onPrefabAdded) where TComponent : Component
        {
            var childItems = new Dictionary<TKey, TComponent>();

            Action<Dictionary<TKey, TValue>> update = dict =>
            {
                // Remove items that are no longer in the list.
                var removed = new List<TKey>();

                foreach (var (fromItem, toItem) in childItems)
                {
                    // In edit mode remove everything, so we can test data changes
                    if (!dict.ContainsKey(fromItem) || !Application.isPlaying)
                    {
                        toItem.gameObject.Destroy();
                        removed.Add(fromItem);
                    }
                }

                foreach (var item in removed)
                {
                    childItems.Remove(item);
                }

                // Add items that are new to the list.
                foreach (var (key, value) in dict)
                {
                    if (!childItems.TryGetValue(key, out var toItem))
                    {
                        toItem = UnityEngine.Object.Instantiate(prefab, parent);
                        childItems.Add(key, toItem);
                        onPrefabAdded(key, value, toItem);
                    }
                }
            };

            void Subscribe(Action<Dictionary<TKey, TValue>> action)
            {
                prop.OnChangeWithValue += action;
            }

            void Unsubscribe(Action<Dictionary<TKey, TValue>> action)
            {
                prop.OnChangeWithValue -= action;

                foreach (var (_, toItem) in childItems)
                {
                    toItem.gameObject.Destroy();
                }
            }

            Bind(context, Subscribe, Unsubscribe, update);
            update(prop.Value);
            return childItems;
        }
    }
}
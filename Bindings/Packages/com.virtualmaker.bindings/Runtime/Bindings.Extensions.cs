using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace VirtualMaker.Bindings.Extensions
{
    public static partial class BindingsExtensions
    {
        public static void BindDeferred<T>(this UnityEngine.Object obj, IProperty<T> property, Action<T> action, CancellationToken cancellationToken = default)
            => BindingsInternal.BindDeferred(new(obj, cancellationToken), property, action);

        public static void BindDeferred(this UnityEngine.Object obj, IPropertyChange property, Action action, CancellationToken cancellationToken = default)
            => BindingsInternal.BindDeferred(new(obj, cancellationToken), property, action);

        public static void BindDeferred(this UnityEngine.Object obj, Action action, params IPropertyChange[] props)
            => BindingsInternal.BindDeferred(new(), action, props);

        public static void BindDeferred(this UnityEngine.Object obj, Action action, CancellationToken cancellationToken, params IPropertyChange[] props)
            => BindingsInternal.BindDeferred(new(obj, cancellationToken), action, props);

        public static void BindDeferred<T>(this UnityEngine.Object obj, IProperty<T> prop, IPropertySet<T> prop2, CancellationToken cancellationToken = default)
            => BindingsInternal.BindDeferred(new(obj, cancellationToken), prop, prop2);

        public static void BindDeferred<T0, T1>(this UnityEngine.Object obj, IProperty<T0> prop, IPropertySet<T1> prop2, Func<T0, T1> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.BindDeferred(new(obj, cancellationToken), prop, prop2, transform);

        public static void BindDeferred<T>(this UnityEngine.Object obj, IPropertySet<T> prop, IPropertySet<T> prop2, bool twoWay, CancellationToken cancellationToken = default)
            => BindingsInternal.BindDeferred(new(obj, cancellationToken), prop, prop2, twoWay);

        public static void Bind<T>(this UnityEngine.Object obj, IProperty<T> prop, Action<T> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), prop, action);

        public static void Bind(this UnityEngine.Object obj, IPropertyChange prop, Action action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), prop, action);

        public static void Bind(this UnityEngine.Object obj, Action action, params IPropertyChange[] props)
            => BindingsInternal.Bind(new(), action, props);

        public static void Bind(this UnityEngine.Object obj, Action action, CancellationToken cancellationToken, params IPropertyChange[] props)
            => BindingsInternal.Bind(new(obj, cancellationToken), action, props);

        public static void Bind<T>(this UnityEngine.Object obj, IProperty<T> prop, IPropertySet<T> prop2, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), prop, prop2);

        public static void Bind<T1, T2>(this UnityEngine.Object obj, IProperty<T1> prop, IPropertySet<T2> prop2, Func<T1, T2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), prop, prop2, transform);

        public static void Bind<T>(this UnityEngine.Object obj, Property<T> prop, IPropertySet<T> prop2, bool twoWay, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), prop, prop2, twoWay);

        public static void Bind(this UnityEngine.Object obj, BindableEvent evt, Func<Task> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), evt, action);

        public static void Bind<T>(this UnityEngine.Object obj, BindableEvent<T> evt, Func<T, Task> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), evt, action);

        public static void Bind<T0, T1>(this UnityEngine.Object obj, BindableEvent<T0, T1> evt, Func<T0, T1, Task> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), evt, action);

        public static void Bind(this UnityEngine.Object obj, BindableEvent evt, Action action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), evt, action);

        public static void Bind<T>(this UnityEngine.Object obj, BindableEvent<T> evt, Action<T> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), evt, action);

        public static void Bind<T0, T1>(this UnityEngine.Object obj, BindableEvent<T0, T1> evt, Action<T0, T1> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), evt, action);

        public static void Bind(this UnityEngine.Object obj, UnityEvent evt, Func<Task> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), evt, action);

        public static void Bind(this UnityEngine.Object obj, UnityEvent evt, Action action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), evt, action);

        public static void Bind<T>(this UnityEngine.Object obj, UnityEvent<T> evt, Func<T, Task> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), evt, action);

        public static void Bind<T>(this UnityEngine.Object obj, UnityEvent<T> evt, Action<T> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), evt, action);

        public static void Bind<T0, T1>(this UnityEngine.Object obj, UnityEvent<T0, T1> evt, Func<T0, T1, Task> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), evt, action);

        public static void Bind<T0, T1>(this UnityEngine.Object obj, UnityEvent<T0, T1> evt, Action<T0, T1> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), evt, action);

        public static void Bind<T0, T1, T2>(this UnityEngine.Object obj, UnityEvent<T0, T1, T2> evt, Func<T0, T1, T2, Task> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), evt, action);

        public static void Bind<T0, T1, T2>(this UnityEngine.Object obj, UnityEvent<T0, T1, T2> evt, Action<T0, T1, T2> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), evt, action);

        public static void Bind<T0, T1, T2, T3>(this UnityEngine.Object obj, UnityEvent<T0, T1, T2, T3> evt, Func<T0, T1, T2, T3, Task> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), evt, action);

        public static void Bind<T0, T1, T2, T3>(this UnityEngine.Object obj, UnityEvent<T0, T1, T2, T3> evt, Action<T0, T1, T2, T3> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), evt, action);

        public static void BindUpdate(this UnityEngine.Object obj, Action updateFunc, Func<bool> doneFunc = null, CancellationToken cancellationToken = default)
            => BindingsInternal.BindUpdate(new(obj, cancellationToken), updateFunc, doneFunc);

        public static void BindLateUpdate(this UnityEngine.Object obj, Action updateFunc, Func<bool> doneFunc = null, CancellationToken cancellationToken = default)
            => BindingsInternal.BindLateUpdate(new(obj, cancellationToken), updateFunc, doneFunc);

        public static void BindInterval(this UnityEngine.Object obj, float seconds, Action updateFunc, Func<bool> doneFunc = null, CancellationToken cancellationToken = default)
            => BindingsInternal.BindInterval(new(obj, cancellationToken), seconds, updateFunc, doneFunc);

        public static void Animate(this UnityEngine.Object obj, AnimationCurve curve, Action<float> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Animate(new(obj, cancellationToken), curve, action);

        public static async Task AnimateAsync(this UnityEngine.Object obj, AnimationCurve curve, Action<float> action, CancellationToken cancellationToken = default)
            => await BindingsInternal.AnimateAsync(new(obj, cancellationToken), curve, action);

        public static IProperty<float> CreateTransition(this UnityEngine.Object obj, IProperty<bool> prop, AnimationCurve curve, CancellationToken cancellationToken = default)
            => BindingsInternal.CreateTransition(new(obj, cancellationToken), prop, curve);

        public static async Task WaitUntilAsync(this UnityEngine.Object obj, IProperty<bool> prop, CancellationToken cancellationToken = default)
            => await BindingsInternal.WaitUntilAsync(new(obj, cancellationToken), prop);

        /// GameObject.activeSelf

        public static void BindActiveSelf(this GameObject obj, IProperty<bool> prop, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), prop, obj.SetActive);

        public static void BindActiveSelf<T>(this GameObject obj, IProperty<T> property, Func<T, bool> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(obj, cancellationToken), property, v => obj.SetActive(transform(v)));

        /// Component.enabled

        public static void BindEnabled(this MonoBehaviour component, IProperty<bool> prop, CancellationToken cancellationToken = default)
            => component.Bind(prop, v => component.enabled = v, cancellationToken);

        public static void BindEnabled<T>(this MonoBehaviour component, IProperty<T> prop, Func<T, bool> transform, CancellationToken cancellationToken = default)
            => component.Bind(prop, v => component.enabled = transform(v), cancellationToken);

        public static void BindEnabled(this Renderer component, IProperty<bool> prop, CancellationToken cancellationToken = default)
            => component.Bind(prop, v => component.enabled = v, cancellationToken);

        public static void BindEnabled<T>(this Renderer component, IProperty<T> prop, Func<T, bool> transform, CancellationToken cancellationToken = default)
            => component.Bind(prop, v => component.enabled = transform(v), cancellationToken);

        public static void BindEnabled(this Collider component, IProperty<bool> prop, CancellationToken cancellationToken = default)
            => component.Bind(prop, v => component.enabled = v, cancellationToken);

        public static void BindEnabled<T>(this Collider component, IProperty<T> prop, Func<T, bool> transform, CancellationToken cancellationToken = default)
            => component.Bind(prop, v => component.enabled = transform(v), cancellationToken);

        /// Transform.position

        public static void BindPositionUpdate(this Transform transform, Func<Vector3> func, Func<bool> doneFunc = null, CancellationToken cancellationToken = default)
            => transform.BindUpdate(() => transform.position = func(), doneFunc, cancellationToken);

        public static void BindPositionLerp(this Transform transform, IProperty<Vector3> prop, float t, Func<bool> doneFunc = null, CancellationToken cancellationToken = default)
            => transform.BindUpdate(() => transform.position = Vector3.Lerp(transform.position, prop.Value, t * Time.smoothDeltaTime), doneFunc, cancellationToken);

        public static void BindPositionLerp(this Transform transform, Transform target, float t, Func<bool> doneFunc = null, CancellationToken cancellationToken = default)
            => transform.BindUpdate(() => transform.position = Vector3.Lerp(transform.position, target.position, t * Time.smoothDeltaTime), doneFunc, cancellationToken);

        public static void BindPositionMoveTowards(this Transform transform, IProperty<Vector3> prop, float maxDistanceDelta, Func<bool> doneFunc = null, CancellationToken cancellationToken = default)
            => transform.BindUpdate(() => transform.position = Vector3.MoveTowards(transform.position, prop.Value, maxDistanceDelta), doneFunc, cancellationToken);

        public static void BindPositionMoveTowards(this Transform transform, Transform target, float maxDistanceDelta, Func<bool> doneFunc = null, CancellationToken cancellationToken = default)
            => transform.BindUpdate(() => transform.position = Vector3.MoveTowards(transform.position, target.position, maxDistanceDelta), doneFunc, cancellationToken);
    }
}
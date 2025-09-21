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

        /// GAMEOBJECT

        public static void BindActiveSelf(this GameObject obj, IProperty<bool> property)
            => obj.Bind(property, v => obj.SetActive(v));

        public static void BindActiveSelf<T>(this GameObject obj, IProperty<T> property, Func<T, bool> transform)
            => obj.Bind(property, v => obj.SetActive(transform(v)));

        public static void BindActiveSelf(this GameObject obj, Func<bool> func)
             => obj.BindUpdate(() => obj.SetActive(func()));

        public static void BindActiveSelfInterval(this GameObject obj, float seconds, Func<bool> func)
            => obj.BindInterval(seconds, () => obj.SetActive(func()));

        public static void BindActiveSelf(this GameObject obj, IProperty<bool> property, CancellationToken cancellationToken = default)
            => obj.Bind(property, v => obj.SetActive(v), cancellationToken);


        /// COMPONENT

        public static void BindEnabled(this MonoBehaviour component, IProperty<bool> property)
            => component.Bind(property, v => component.enabled = v);

        public static void BindEnabled<T>(this MonoBehaviour component, IProperty<T> property, Func<T, bool> transform)
            => component.Bind(property, v => component.enabled = transform(v));

        public static void BindEnabled(this Renderer component, IProperty<bool> property)
            => component.Bind(property, v => component.enabled = v);

        public static void BindEnabled<T>(this Renderer component, IProperty<T> property, Func<T, bool> transform)
            => component.Bind(property, v => component.enabled = transform(v));

        public static void BindEnabled(this Collider component, IProperty<bool> property)
            => component.Bind(property, v => component.enabled = v);

        public static void BindEnabled<T>(this Collider component, IProperty<T> property, Func<T, bool> transform)
            => component.Bind(property, v => component.enabled = transform(v));
    }
}
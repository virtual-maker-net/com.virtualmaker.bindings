using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace VirtualMaker.Bindings
{
    public static class Bindings3
    {
        public static void BindDeferred<T>(IProperty<T> property, Action<T> action, CancellationToken cancellationToken = default)
            => BindingsInternal.BindDeferred(new(cancellationToken), property, action);

        public static void BindDeferred(IPropertyChange property, Action action, CancellationToken cancellationToken = default)
            => BindingsInternal.BindDeferred(new(cancellationToken), property, action);

        public static void BindDeferred(Action action, params IPropertyChange[] props)
            => BindingsInternal.BindDeferred(new(), action, props);

        public static void BindDeferred(Action action, CancellationToken cancellationToken, params IPropertyChange[] props)
            => BindingsInternal.BindDeferred(new(cancellationToken), action, props);

        public static void BindDeferred<T>(IProperty<T> prop, IPropertySet<T> prop2, CancellationToken cancellationToken = default)
            => BindingsInternal.BindDeferred(new(cancellationToken), prop, prop2);

        public static void BindDeferred<T0, T1>(IProperty<T0> prop, IPropertySet<T1> prop2, Func<T0, T1> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.BindDeferred(new(cancellationToken), prop, prop2, transform);

        public static void BindDeferred<T>(IPropertySet<T> prop, IPropertySet<T> prop2, bool twoWay, CancellationToken cancellationToken = default)
            => BindingsInternal.BindDeferred(new(cancellationToken), prop, prop2, twoWay);

        public static void Bind<T>(IProperty<T> prop, Action<T> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(cancellationToken), prop, action);

        public static void Bind(IPropertyChange prop, Action action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(cancellationToken), prop, action);

        public static void Bind(Action action, params IPropertyChange[] props)
            => BindingsInternal.Bind(new(), action, props);

        public static void Bind(Action action, CancellationToken cancellationToken, params IPropertyChange[] props)
            => BindingsInternal.Bind(new(cancellationToken), action, props);

        public static void Bind<T>(IProperty<T> prop, IPropertySet<T> prop2, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(cancellationToken), prop, prop2);

        public static void Bind<T1, T2>(IProperty<T1> prop, IPropertySet<T2> prop2, Func<T1, T2> transform, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(cancellationToken), prop, prop2, transform);

        public static void Bind<T>(Property<T> prop, IPropertySet<T> prop2, bool twoWay, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(cancellationToken), prop, prop2, twoWay);

        public static void Bind(BindableEvent evt, Func<Task> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(cancellationToken), evt, action);

        public static void Bind<T>(BindableEvent<T> evt, Func<T, Task> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(cancellationToken), evt, action);

        public static void Bind<T0, T1>(BindableEvent<T0, T1> evt, Func<T0, T1, Task> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(cancellationToken), evt, action);

        public static void Bind(BindableEvent evt, Action action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(cancellationToken), evt, action);

        public static void Bind<T>(BindableEvent<T> evt, Action<T> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(cancellationToken), evt, action);

        public static void Bind<T0, T1>(BindableEvent<T0, T1> evt, Action<T0, T1> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(cancellationToken), evt, action);

        public static void Bind(UnityEvent evt, Func<Task> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(cancellationToken), evt, action);

        public static void Bind(UnityEvent evt, Action action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(cancellationToken), evt, action);

        public static void Bind<T>(UnityEvent<T> evt, Func<T, Task> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(cancellationToken), evt, action);

        public static void Bind<T>(UnityEvent<T> evt, Action<T> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(cancellationToken), evt, action);

        public static void Bind<T0, T1>(UnityEvent<T0, T1> evt, Func<T0, T1, Task> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(cancellationToken), evt, action);

        public static void Bind<T0, T1>(UnityEvent<T0, T1> evt, Action<T0, T1> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(cancellationToken), evt, action);

        public static void Bind<T0, T1, T2>(UnityEvent<T0, T1, T2> evt, Func<T0, T1, T2, Task> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(cancellationToken), evt, action);

        public static void Bind<T0, T1, T2>(UnityEvent<T0, T1, T2> evt, Action<T0, T1, T2> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(cancellationToken), evt, action);

        public static void Bind<T0, T1, T2, T3>(UnityEvent<T0, T1, T2, T3> evt, Func<T0, T1, T2, T3, Task> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(cancellationToken), evt, action);

        public static void Bind<T0, T1, T2, T3>(UnityEvent<T0, T1, T2, T3> evt, Action<T0, T1, T2, T3> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Bind(new(cancellationToken), evt, action);

        public static void BindUpdate(Action updateFunc, Func<bool> doneFunc = null, CancellationToken cancellationToken = default)
            => BindingsInternal.BindUpdate(new(cancellationToken), updateFunc, doneFunc);

        public static void BindLateUpdate(Action updateFunc, Func<bool> doneFunc = null, CancellationToken cancellationToken = default)
            => BindingsInternal.BindLateUpdate(new(cancellationToken), updateFunc, doneFunc);

        public static void BindInterval(float seconds, Action updateFunc, Func<bool> doneFunc = null, CancellationToken cancellationToken = default)
            => BindingsInternal.BindInterval(new(cancellationToken), seconds, updateFunc, doneFunc);

        public static void Animate(AnimationCurve curve, Action<float> action, CancellationToken cancellationToken = default)
            => BindingsInternal.Animate(new(cancellationToken), curve, action);

        public static async Task AnimateAsync(AnimationCurve curve, Action<float> action, CancellationToken cancellationToken = default)
            => await BindingsInternal.AnimateAsync(new(cancellationToken), curve, action);

        public static IProperty<float> CreateTransition(IProperty<bool> prop, AnimationCurve curve, CancellationToken cancellationToken = default)
            => BindingsInternal.CreateTransition(new(cancellationToken), prop, curve);

        public static async Task WaitUntilAsync(IProperty<bool> prop, CancellationToken cancellationToken = default)
            => await BindingsInternal.WaitUntilAsync(new(cancellationToken), prop);
    }
}
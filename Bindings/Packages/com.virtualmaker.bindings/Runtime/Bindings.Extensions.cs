using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace VirtualMaker.Bindings.Extensions
{
    public static partial class BindingsExtensions
    {
        /// GAMEOBJECT

        public static void BindActiveSelf(this GameObject obj, IProperty<bool> property)
            => Bindings2._scope.Bind(property, v => obj.SetActive(v));

        public static void BindActiveSelf<T>(this GameObject obj, IProperty<T> property, Func<T, bool> transform)
            => Bindings2._scope.Bind(property, v => obj.SetActive(transform(v)));

       public static void BindActiveSelf(this GameObject obj, Func<bool> func)
            => Bindings2._scope.BindUpdate(() => obj.SetActive(func()));

        public static void BindActiveSelfInterval(this GameObject obj, float seconds, Func<bool> func)
            => Bindings2._scope.BindInterval(seconds, () => obj.SetActive(func()));

        /// COMPONENT

        public static void BindEnabled(this MonoBehaviour component, IProperty<bool> property)
            => Bindings2._scope.Bind(property, v => component.enabled = v);

        public static void BindEnabled<T>(this MonoBehaviour component, IProperty<T> property, Func<T, bool> transform)
            => Bindings2._scope.Bind(property, v => component.enabled = transform(v));

        public static void BindEnabled(this MonoBehaviour component, Func<bool> func)
            => Bindings2._scope.BindUpdate(() => component.enabled = func());

        public static void BindEnabledInterval(this MonoBehaviour component, float seconds, Func<bool> func)
            => Bindings2._scope.BindInterval(seconds, () => component.enabled = func());

        /// EVENTS

        public static void Bind(this UnityEvent evt, UnityAction action)
            => Bindings2._scope.Bind(evt, action);

        public static void Bind(this UnityEvent evt, Func<Task> action)
            => Bindings2._scope.Bind(evt, action);

        public static void Bind<T>(this UnityEvent<T> evt, UnityAction<T> action)
            => Bindings2._scope.Bind(evt, action);
    }
}
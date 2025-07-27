using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

namespace VirtualMaker.Bindings.Extensions
{
    public static partial class BindingsExtensions
    {
        /// GAMEOBJECT

        public static void BindActiveSelf(this GameObject obj, Bindings2 bindings, IProperty<bool> property)
            => bindings.Bind(property, v => obj.SetActive(v));

        public static void BindActiveSelf(this GameObject obj, IProperty<bool> property)
            => BindActiveSelf(obj, Bindings2._scope, property);

        public static void BindActiveSelf(this GameObject obj, Bindings2 bindings, Func<bool> func)
            => bindings.BindUpdate(() => obj.SetActive(func()));

        public static void BindActiveSelf(this GameObject obj, Func<bool> func)
            => BindActiveSelf(obj, Bindings2._scope, func);

        public static void BindActiveSelfInterval(this GameObject obj, Bindings2 bindings, float seconds, Func<bool> func)
            => bindings.BindInterval(seconds, () => obj.SetActive(func()));

        public static void BindActiveSelfInterval(this GameObject obj, float seconds, Func<bool> func)
            => BindActiveSelfInterval(obj, Bindings2._scope, seconds, func);

        /// COMPONENT

        public static void BindEnabled(this MonoBehaviour component, Bindings2 bindings, IProperty<bool> property)
            => bindings.Bind(property, v => component.enabled = v);

        public static void BindEnabled(this MonoBehaviour component, IProperty<bool> property)
            => BindEnabled(component, Bindings2._scope, property);

        public static void BindEnabled(this MonoBehaviour component, Bindings2 bindings, Func<bool> func)
            => bindings.BindUpdate(() => component.enabled = func());

        public static void BindEnabled(this MonoBehaviour component, Func<bool> func)
            => BindEnabled(component, Bindings2._scope, func);

        public static void BindEnabledInterval(this MonoBehaviour component, Bindings2 bindings, float seconds, Func<bool> func)
            => bindings.BindInterval(seconds, () => component.enabled = func());

        public static void BindEnabledInterval(this MonoBehaviour component, float seconds, Func<bool> func)
            => BindEnabledInterval(component, Bindings2._scope, seconds, func);


        /// EVENTS

        public static void Bind(this UnityEvent evt, UnityAction action)
            => Bindings2._scope.Bind(evt, action);

        public static void Bind(this UnityEvent evt, Func<Task> action)
            => Bindings2._scope.Bind(evt, action);

        public static void Bind<T>(this UnityEvent<T> evt, UnityAction<T> action)
            => Bindings2._scope.Bind(evt, action);
    }
}
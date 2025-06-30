using System;
using System.Threading.Tasks;
using UnityEngine.Events;

namespace VirtualMaker.Bindings.Extensions
{
    public static partial class BindingsExtensions
    {
        /// EVENTS

        public static void Bind(this UnityEvent evt, UnityAction action)
            => Bindings2._scope.Bind(evt, action);

        public static void Bind(this UnityEvent evt, Func<Task> action)
            => Bindings2._scope.Bind(evt, action);

        public static void Bind<T>(this UnityEvent<T> evt, UnityAction<T> action)
            => Bindings2._scope.Bind(evt, action);
    }
}
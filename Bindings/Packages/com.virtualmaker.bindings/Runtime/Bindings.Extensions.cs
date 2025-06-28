using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TMPro;
using UnityEngine.Events;
using UnityEngine.UIElements;

namespace VirtualMaker.Bindings.Extensions
{
    public static partial class BindingsExtensions
    {
        private static Dictionary<UnityEngine.Object, Bindings2> _bindings = new();
        private static UnityEngine.Object _lastContext;
        private static Bindings2 _lastBindings;

        public static Bindings2 GetBindings(UnityEngine.Object context)
        {
            // Skip dictionary lookup, to speed up bindings done in sequence.
            if (context == _lastContext)
            {
                return _lastBindings;
            }

            if (!_bindings.TryGetValue(context, out var bindings))
            {
                bindings = new(context);
                _bindings.Add(context, bindings);
            }

            _lastContext = context;
            _lastBindings = bindings;
            return bindings;
        }

        /// BASIC ACTIONS

        public static void Bind<T>(this UnityEngine.Object context, IProperty<T> property, Action<T> action)
            => GetBindings(context).Bind(property, action);

        public static void Bind<T>(this UnityEngine.Object context, IProperty<T> property, Action action)
            => GetBindings(context).Bind(property, action);

        public static void Bind<T>(this UnityEngine.Object context, Property<T> prop1, Property<T> prop2, bool twoWay)
            => GetBindings(context).Bind(prop1, prop2, twoWay);

        public static void BindDeferred<T>(this UnityEngine.Object context, IProperty<T> property, Action<T> action)
            => GetBindings(context).BindDeferred(property, action);

        public static void BindDeferred<T>(this UnityEngine.Object context, IProperty<T> property, Action action)
            => GetBindings(context).BindDeferred(property, action);

        public static void BindDeferred<T>(this UnityEngine.Object context, Property<T> prop1, Property<T> prop2, bool twoWay)
            => GetBindings(context).BindDeferred(prop1, prop2, twoWay);

        // ANIMATIONS

        public static void BindUpdate(this UnityEngine.Object context, Action action, Func<bool> doneFunc = null)
            => GetBindings(context).BindUpdate(action, doneFunc);

        public static void BindLateUpdate(this UnityEngine.Object context, Action action, Func<bool> doneFunc = null)
            => GetBindings(context).BindLateUpdate(action, doneFunc);

        public static void BindUpdate(this UnityEngine.Object context, float seconds, Action action, Func<bool> doneFunc = null)
            => GetBindings(context).BindUpdate(seconds, action, doneFunc);

        // RESET

        public static void ResetBindings(this UnityEngine.Object context)
        {
            GetBindings(context)?.Reset();
            _bindings.Remove(context);

            if (context == _lastContext)
            {
                _lastContext = null;
                _lastBindings = null;
            }
        }

        public static void GarbageCollectBindings()
        {
            var remainingBindings = new Dictionary<UnityEngine.Object, Bindings2>();
            foreach (var (context, bindings) in _bindings)
            {
                if (bindings.IsValid)
                {
                    remainingBindings.Add(context, bindings);
                }
                else
                {
                    bindings.Reset();
                }
            }

            _bindings = remainingBindings;
            _lastContext = null;
            _lastBindings = null;
        }

        /// EVENTS

        public static void Bind(this UnityEngine.Object context, UnityEvent evt, UnityAction action)
            => GetBindings(context).Bind(evt, action);

        public static void Bind(this UnityEngine.Object context, UnityEvent evt, Func<Task> action)
            => GetBindings(context).Bind(evt, action);

        public static void Bind<T>(this UnityEngine.Object context, UnityEvent<T> evt, UnityAction<T> action)
            => GetBindings(context).Bind(evt, action);

        public static void Bind(this UnityEvent evt, UnityEngine.Object context, UnityAction action)
            => GetBindings(context).Bind(evt, action);

        public static void Bind(this UnityEvent evt, UnityEngine.Object context, Func<Task> action)
            => GetBindings(context).Bind(evt, action);

        public static void Bind<T>(this UnityEvent<T> evt, UnityEngine.Object context, UnityAction<T> action)
            => GetBindings(context).Bind(evt, action);
    }
}
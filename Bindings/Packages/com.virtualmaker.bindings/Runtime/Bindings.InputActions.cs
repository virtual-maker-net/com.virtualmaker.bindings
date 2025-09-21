#if UNITY_INPUT_SYSTEM
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

namespace VirtualMaker.Bindings
{
    public static partial class Bindings
    {
        public static void Bind<T>(
            InputActionReference inputActionReference,
            Property<T> performedProp = null, Action<T> onPerformed = null,
            Property<T> startedProp = null, Action<T> onStarted = null,
            Property<T> canceledProp = null, Action<T> onCanceled = null,
            CancellationToken cancellationToken = default)
            where T : struct
            => Bind(new(cancellationToken), inputActionReference, performedProp, onPerformed,
                startedProp, onStarted, canceledProp, onCanceled);

        public static void Bind<T>(
            this UnityEngine.Object obj,
            InputActionReference inputActionReference,
            Property<T> performedProp = null, Action<T> onPerformed = null,
            Property<T> startedProp = null, Action<T> onStarted = null,
            Property<T> canceledProp = null, Action<T> onCanceled = null,
            CancellationToken cancellationToken = default)
            where T : struct
            => Bind(new(obj, cancellationToken), inputActionReference, performedProp, onPerformed,
                startedProp, onStarted, canceledProp, onCanceled);

        internal static void Bind<T>(
            BindingContext context,
            InputActionReference inputActionReference,
            Property<T> performedProp = null, Action<T> onPerformed = null,
            Property<T> startedProp = null, Action<T> onStarted = null,
            Property<T> canceledProp = null, Action<T> onCanceled = null)
            where T : struct
        {
            if (performedProp != null)
            {
                onPerformed?.Invoke(performedProp.Value);
            }

            if (startedProp != null)
            {
                onStarted?.Invoke(startedProp.Value);
            }

            if (canceledProp != null)
            {
                onCanceled?.Invoke(canceledProp.Value);
            }

            BindDeferred(context,
                inputActionReference,
                performedProp, onPerformed,
                startedProp, onStarted,
                canceledProp, onCanceled);
        }

        public static void BindDeferred<T>(
            InputActionReference inputActionReference,
            Property<T> performedProp = null, Action<T> onPerformed = null,
            Property<T> startedProp = null, Action<T> onStarted = null,
            Property<T> canceledProp = null, Action<T> onCanceled = null,
            CancellationToken cancellationToken = default)
            where T : struct
            => BindDeferred(new(cancellationToken), inputActionReference, performedProp, onPerformed,
                startedProp, onStarted, canceledProp, onCanceled);

        public static void BindDeferred<T>(
            this UnityEngine.Object obj,
            InputActionReference inputActionReference,
            Property<T> performedProp = null, Action<T> onPerformed = null,
            Property<T> startedProp = null, Action<T> onStarted = null,
            Property<T> canceledProp = null, Action<T> onCanceled = null,
            CancellationToken cancellationToken = default)
            where T : struct
            => BindDeferred(new(obj, cancellationToken), inputActionReference, performedProp, onPerformed,
                startedProp, onStarted, canceledProp, onCanceled);

        internal static void BindDeferred<T>(
            BindingContext context,
            InputActionReference inputActionReference,
            Property<T> performedProp = null, Action<T> onPerformed = null,
            Property<T> startedProp = null, Action<T> onStarted = null,
            Property<T> canceledProp = null, Action<T> onCanceled = null)
            where T : struct
        {
            void Performed(T value)
            {
                if (performedProp != null)
                {
                    performedProp.Value = value;
                    onPerformed?.Invoke(performedProp.Value);
                }
                else
                {
                    onPerformed?.Invoke(value);
                }
            }

            void Started(T value)
            {
                if (startedProp != null)
                {
                    startedProp.Value = value;
                    onStarted?.Invoke(startedProp.Value);
                }
                else
                {
                    onStarted?.Invoke(value);
                }
            }

            void Canceled(T value)
            {
                if (canceledProp != null)
                {
                    canceledProp.Value = value;
                    onCanceled?.Invoke(canceledProp.Value);
                }
                else
                {
                    onCanceled?.Invoke(value);
                }
            }

            Bind<T>(context, inputActionReference, Performed, Started, Canceled);
        }

        public static void Bind(InputActionReference inputActionReference, Action onPerformed = null, Action onStarted = null, Action onCanceled = null, CancellationToken cancellationToken = default)
            => Bind(new(cancellationToken), inputActionReference, _ => onPerformed?.Invoke(), _ => onStarted?.Invoke(), _ => onCanceled?.Invoke());

        public static void Bind(this UnityEngine.Object obj, InputActionReference inputActionReference, Action onPerformed = null, Action onStarted = null, Action onCanceled = null, CancellationToken cancellationToken = default)
            => Bind(new(obj, cancellationToken), inputActionReference, _ => onPerformed?.Invoke(), _ => onStarted?.Invoke(), _ => onCanceled?.Invoke());

        public static void Bind<T>(this UnityEngine.Object obj, InputActionReference inputActionReference, Action<T> onPerformed = null, Action<T> onStarted = null, Action<T> onCanceled = null, CancellationToken cancellationToken = default) where T : struct
            => Bind(new(obj, cancellationToken), inputActionReference, onPerformed, onStarted, onCanceled);

        internal static void Bind<T>(BindingContext context, InputActionReference inputActionReference, Action<T> onPerformed = null, Action<T> onStarted = null, Action<T> onCanceled = null)
            where T : struct
        {
            var inputAction = inputActionReference.GetAndCloneAction();
            inputAction.Enable();

            void Unsubscribe()
            {
                inputAction.performed -= OnActionPerformed;
                inputAction.started -= OnActionStarted;
                inputAction.canceled -= OnActionCanceled;
                inputAction.Dispose();
            }

            void OnActionPerformed(InputAction.CallbackContext ctx)
            {
                if (context.IsValid)
                {
                    onPerformed(ctx.ReadValue<T>());
                }
                else
                {
                    Unsubscribe();
                }
            }

            inputAction.performed += OnActionPerformed;

            void OnActionStarted(InputAction.CallbackContext ctx)
            {
                if (context.IsValid)
                {
                    onStarted(ctx.ReadValue<T>());
                }
                else
                {
                    Unsubscribe();
                }
            }

            inputAction.started += OnActionStarted;

            void OnActionCanceled(InputAction.CallbackContext ctx)
            {
                if (context.IsValid)
                {
                    onCanceled(ctx.ReadValue<T>());
                }
                else
                {
                    Unsubscribe();
                }
            }

            inputAction.canceled += OnActionCanceled;
        }

        public static void Bind(
            InputActionReference inputActionReference,
            Action<InputAction.CallbackContext> onPerformed = null,
            Action<InputAction.CallbackContext> onStarted = null,
            Action<InputAction.CallbackContext> onCanceled = null,
            CancellationToken cancellationToken = default)
            => Bind(new(cancellationToken), inputActionReference, onPerformed, onStarted, onCanceled);

        public static void Bind(
            UnityEngine.Object obj,
            InputActionReference inputActionReference,
            Action<InputAction.CallbackContext> onPerformed = null,
            Action<InputAction.CallbackContext> onStarted = null,
            Action<InputAction.CallbackContext> onCanceled = null,
            CancellationToken cancellationToken = default)
            => Bind(new(obj, cancellationToken), inputActionReference, onPerformed, onStarted, onCanceled);

        internal static void Bind(
            BindingContext context,
            InputActionReference inputActionReference,
            Action<InputAction.CallbackContext> onPerformed = null,
            Action<InputAction.CallbackContext> onStarted = null,
            Action<InputAction.CallbackContext> onCanceled = null)
        {
            var inputAction = inputActionReference.GetAndCloneAction();
            inputAction.Enable();

            void Unsubscribe()
            {
                inputAction.performed -= OnActionPerformed;
                inputAction.started -= OnActionStarted;
                inputAction.canceled -= OnActionCanceled;
                inputAction.Dispose();
            }

            void OnActionPerformed(InputAction.CallbackContext ctx)
            {
                if (context.IsValid)
                {
                    onPerformed(ctx);
                }
                else
                {
                    Unsubscribe();
                }
            }

            inputAction.performed += OnActionPerformed;

            void OnActionStarted(InputAction.CallbackContext ctx)
            {
                if (context.IsValid)
                {
                    onStarted(ctx);
                }
                else
                {
                    Unsubscribe();
                }
            }

            inputAction.started += OnActionStarted;

            void OnActionCanceled(InputAction.CallbackContext ctx)
            {
                if (context.IsValid)
                {
                    onCanceled(ctx);
                }
                else
                {
                    Unsubscribe();
                }
            }

            inputAction.canceled += OnActionCanceled;
        }
    }

    internal static class InputSystemExtensions
    {
        public static InputAction GetAndCloneAction(this InputActionReference reference)
        {
#if UNITY_INPUT_SYSTEM_1_8_OR_HIGHER
            var action = InputSystem.actions.FindAction(reference.action.id);
#else // UNITY_INPUT_SYSTEM_1_8_OR_HIGHER
            var action = reference.ToInputAction();
#endif // UNITY_INPUT_SYSTEM_1_8_OR_HIGHER
            if (action == null)
            {
                throw new MissingReferenceException($"Failed to find input action for input action: [{reference.action.id}] {reference.name}");
            }

            return action.Clone();
        }
    }
}
#endif // UNITY_INPUT_SYSTEM

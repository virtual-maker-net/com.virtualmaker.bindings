#if UNITY_INPUT_SYSTEM
using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace VirtualMaker.Bindings
{
    public partial class Bindings
    {
        public void Bind<T>(InputActionReference inputActionReference,
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

            BindDeferred(inputActionReference,
                performedProp, onPerformed,
                startedProp, onStarted,
                canceledProp, onCanceled);
        }

        public void BindDeferred<T>(InputActionReference inputActionReference,
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

            On<T>(inputActionReference, Performed, Started, Canceled);
        }

        public void On(InputActionReference inputActionReference, Action onPerformed, Action onStarted = null, Action onCanceled = null)
            => On(inputActionReference, _ => onPerformed?.Invoke(), _ => onStarted?.Invoke(), _ => onCanceled?.Invoke());

        public void On<T>(InputActionReference inputActionReference, Action<T> onPerformed, Action<T> onStarted = null, Action<T> onCancelled = null)
            where T : struct
        {
            var inputAction = inputActionReference.GetAndCloneAction();
            inputAction.Enable();

            // add first to make sure we disable input action
            // before unsubscribing to callback events.
            AddUnsubscriber(() => inputAction.Disable());

            if (onPerformed != null)
            {
                inputAction.performed += OnActionPerformed;
            }

            if (onStarted != null)
            {
                inputAction.started += OnActionStarted;
                AddUnsubscriber(() => inputAction.started -= OnActionStarted);
            }

            if (onCancelled != null)
            {
                inputAction.canceled += OnActionCanceled;
                AddUnsubscriber(() => inputAction.canceled -= OnActionCanceled);
            }

            // add last so make sure we unsubscribe to started/canceled callbacks
            // before disposing of the input action.
            AddUnsubscriber(() =>
            {
                if (onPerformed != null)
                {
                    inputAction.performed -= OnActionPerformed;
                }

                inputAction.Dispose();
            });

            return;
            void OnActionPerformed(InputAction.CallbackContext ctx) => onPerformed(ctx.ReadValue<T>());
            void OnActionStarted(InputAction.CallbackContext ctx) => onStarted(ctx.ReadValue<T>());
            void OnActionCanceled(InputAction.CallbackContext ctx) => onCancelled(ctx.ReadValue<T>());
        }

        public void On(InputActionReference inputActionReference, Action<InputAction.CallbackContext> onPerformed, Action<InputAction.CallbackContext> onStarted = null, Action<InputAction.CallbackContext> onCanceled = null)
        {
            var inputAction = inputActionReference.GetAndCloneAction();
            inputAction.Enable();

            // add first to make sure we disable input action
            // before unsubscribing to callback events.
            AddUnsubscriber(() => inputAction.Disable());

            if (onPerformed != null)
            {
                inputAction.performed += OnActionPerformed;
            }

            if (onStarted != null)
            {
                inputAction.started += OnActionStarted;
                AddUnsubscriber(() => inputAction.started -= OnActionStarted);
            }

            if (onCanceled != null)
            {
                inputAction.canceled += OnActionCanceled;
                AddUnsubscriber(() => inputAction.canceled -= OnActionCanceled);
            }

            // add last so make sure we unsubscribe to started/canceled callbacks
            // before disposing of the input action.
            AddUnsubscriber(() =>
            {
                if (onPerformed != null)
                {
                    inputAction.performed -= OnActionPerformed;
                }

                inputAction.Dispose();
            });

            return;
            void OnActionPerformed(InputAction.CallbackContext ctx) => onPerformed(ctx);
            void OnActionStarted(InputAction.CallbackContext ctx) => onStarted(ctx);
            void OnActionCanceled(InputAction.CallbackContext ctx) => onCanceled(ctx);
        }
    }

    internal static class InputSystemExtensions
    {
        public static InputAction GetAndCloneAction(this InputActionReference reference)
        {
#if UNITY_INPUT_SYSTEM_1_8_OR_HIGHER
            var action = InputSystem.actions.FindAction(reference.action.id);
#else
            var action = reference.ToInputAction();
#endif
            if (action == null)
            {
                throw new MissingReferenceException($"Failed to find input action for input action: [{reference.action.id}] {reference.name}");
            }

            return action.Clone();
        }
    }
}
#endif // UNITY_INPUT_SYSTEM

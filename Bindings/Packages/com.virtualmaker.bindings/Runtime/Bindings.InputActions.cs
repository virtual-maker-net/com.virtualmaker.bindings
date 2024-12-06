#if UNITY_INPUT_SYSTEM
using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace VirtualMaker.Bindings
{
    public partial class Bindings
    {
        public void Bind<T>(InputActionReference inputActionReference,
            Property<T> performedProp, Property<T> startedProp = null, Property<T> canceledProp = null,
            Action<T> performedCb = null, Action<T> startedCb = null, Action<T> canceledCb = null)
            where T : struct
        {
            if (performedProp != null)
            {
                performedCb?.Invoke(performedProp.Value);
            }

            if (startedProp != null)
            {
                startedCb?.Invoke(startedProp.Value);
            }

            if (canceledProp != null)
            {
                canceledCb?.Invoke(canceledProp.Value);
            }

            BindDeferred(inputActionReference,
                performedProp, startedProp, canceledProp,
                performedCb, startedCb, canceledCb);
        }

        public void BindDeferred<T>(InputActionReference inputActionReference,
            Property<T> performedProp, Property<T> startedProp = null, Property<T> canceledProp = null,
            Action<T> performedCb = null, Action<T> startedCb = null, Action<T> canceledCb = null)
            where T : struct
        {
            void Performed(T value)
            {
                if (performedProp != null)
                {
                    performedProp.Value = value;
                    performedCb?.Invoke(performedProp.Value);
                }
                else
                {
                    performedCb?.Invoke(value);
                }
            }

            void Started(T value)
            {
                if (startedProp != null)
                {
                    startedProp.Value = value;
                    startedCb?.Invoke(startedProp.Value);
                }
                else
                {
                    startedCb?.Invoke(value);
                }
            }

            void Canceled(T value)
            {
                if (canceledProp != null)
                {
                    canceledProp.Value = value;
                    canceledCb?.Invoke(canceledProp.Value);
                }
                else
                {
                    canceledCb?.Invoke(value);
                }
            }

            On<T>(inputActionReference, Performed, Started, Canceled);
        }

        public void On(InputActionReference inputActionReference, Action performed, Action started = null, Action canceled = null)
            => On(inputActionReference, _ => performed?.Invoke(), _ => started?.Invoke(), _ => canceled?.Invoke());

        public void On<T>(InputActionReference inputActionReference, Action<T> performed, Action<T> started = null, Action<T> canceled = null)
            where T : struct
        {
            var inputAction = inputActionReference.GetAndCloneAction();
            inputAction.Enable();

            // add first to make sure we disable input action
            // before unsubscribing to callback events.
            AddUnsubscriber(() => inputAction.Disable());

            if (performed != null)
            {
                inputAction.performed += OnActionPerformed;
            }

            if (started != null)
            {
                inputAction.started += OnActionStarted;
                AddUnsubscriber(() => inputAction.started -= OnActionStarted);
            }

            if (canceled != null)
            {
                inputAction.canceled += OnActionCanceled;
                AddUnsubscriber(() => inputAction.canceled -= OnActionCanceled);
            }

            // add last so make sure we unsubscribe to started/canceled callbacks
            // before disposing of the input action.
            AddUnsubscriber(() =>
            {
                if (performed != null)
                {
                    inputAction.performed -= OnActionPerformed;
                }

                inputAction.Dispose();
            });

            return;
            void OnActionPerformed(InputAction.CallbackContext ctx) => performed(ctx.ReadValue<T>());
            void OnActionStarted(InputAction.CallbackContext ctx) => started(ctx.ReadValue<T>());
            void OnActionCanceled(InputAction.CallbackContext ctx) => canceled(ctx.ReadValue<T>());
        }

        public void On(InputActionReference inputActionReference, Action<InputAction.CallbackContext> performed, Action<InputAction.CallbackContext> started = null, Action<InputAction.CallbackContext> canceled = null)
        {
            var inputAction = inputActionReference.GetAndCloneAction();
            inputAction.Enable();

            // add first to make sure we disable input action
            // before unsubscribing to callback events.
            AddUnsubscriber(() => inputAction.Disable());

            if (performed != null)
            {
                inputAction.performed += OnActionPerformed;
            }

            if (started != null)
            {
                inputAction.started += OnActionStarted;
                AddUnsubscriber(() => inputAction.started -= OnActionStarted);
            }

            if (canceled != null)
            {
                inputAction.canceled += OnActionCanceled;
                AddUnsubscriber(() => inputAction.canceled -= OnActionCanceled);
            }

            // add last so make sure we unsubscribe to started/canceled callbacks
            // before disposing of the input action.
            AddUnsubscriber(() =>
            {
                if (performed != null)
                {
                    inputAction.performed -= OnActionPerformed;
                }

                inputAction.Dispose();
            });

            return;
            void OnActionPerformed(InputAction.CallbackContext ctx) => performed(ctx);
            void OnActionStarted(InputAction.CallbackContext ctx) => started(ctx);
            void OnActionCanceled(InputAction.CallbackContext ctx) => canceled(ctx);
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

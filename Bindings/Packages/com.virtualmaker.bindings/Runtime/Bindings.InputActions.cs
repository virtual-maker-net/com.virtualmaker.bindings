#if UNITY_INPUT_SYSTEM
using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace VirtualMaker.Bindings
{
    public partial class Bindings
    {
        public void Bind(InputActionReference inputActionReference, Action performed, Action started = null, Action cancelled = null)
            => Bind(inputActionReference, _ => performed?.Invoke(), _ => started?.Invoke(), _ => cancelled?.Invoke());

        public void Bind<T>(InputActionReference inputActionReference, Property<T> property) where T : struct
            => Bind<T>(inputActionReference, value => property.Value = value);

        public void Bind<T>(InputActionReference inputActionReference, Property<T> performed, Property<T> started, Property<T> cancelled = null)
            where T : struct
        {
            Bind<T>(inputActionReference, value => performed.Value = value);

            if (started != null)
            {
                Bind<T>(inputActionReference, value => started.Value = value);
            }

            if (cancelled != null)
            {
                Bind<T>(inputActionReference, value => cancelled.Value = value);
            }
        }

        public void Bind<T>(InputActionReference inputActionReference, Action<T> performed, Action<T> started = null, Action<T> cancelled = null)
            where T : struct
        {
            var inputAction = inputActionReference.GetAction();
            inputAction.Enable();
            inputAction.performed += OnActionPerformed;

            AddUnsubscriber(() =>
            {
                inputAction.Disable();
                inputAction.performed -= OnActionPerformed;
            });

            if (started != null)
            {
                inputAction.started += OnActionStarted;
                AddUnsubscriber(() => inputAction.started -= OnActionStarted);
            }

            if (cancelled != null)
            {
                inputAction.canceled += OnActionCanceled;
                AddUnsubscriber(() => inputAction.canceled -= OnActionCanceled);
            }

            return;
            void OnActionPerformed(InputAction.CallbackContext ctx) => performed(ctx.ReadValue<T>());
            void OnActionStarted(InputAction.CallbackContext ctx) => started(ctx.ReadValue<T>());
            void OnActionCanceled(InputAction.CallbackContext ctx) => cancelled(ctx.ReadValue<T>());
        }

        public void Bind(InputActionReference inputActionReference, Action<InputAction.CallbackContext> performed, Action<InputAction.CallbackContext> started = null, Action<InputAction.CallbackContext> cancelled = null)
        {
            var inputAction = inputActionReference.GetAction();
            inputAction.Enable();
            inputAction.performed += OnActionPerformed;

            AddUnsubscriber(() =>
            {
                inputAction.Disable();
                inputAction.performed -= OnActionPerformed;
            });

            if (started != null)
            {
                inputAction.started += OnActionStarted;
                AddUnsubscriber(() => inputAction.started -= OnActionStarted);
            }

            if (cancelled != null)
            {
                inputAction.canceled += OnActionCanceled;
                AddUnsubscriber(() => inputAction.canceled -= OnActionCanceled);
            }

            return;
            void OnActionPerformed(InputAction.CallbackContext ctx) => performed(ctx);
            void OnActionStarted(InputAction.CallbackContext ctx) => started(ctx);
            void OnActionCanceled(InputAction.CallbackContext ctx) => cancelled(ctx);
        }
    }

    internal static class InputSystemExtensions
    {
        public static InputAction GetAction(this InputActionReference reference)
        {
            var action = InputSystem.actions.FindAction(reference.action.id);

            if (action == null)
            {
                throw new MissingReferenceException($"Failed to find input action for {reference.name}");
            }

            return action;
        }
    }
}
#endif // UNITY_INPUT_SYSTEM

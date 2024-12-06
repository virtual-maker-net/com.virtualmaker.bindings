#if UNITY_INPUT_SYSTEM
using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace VirtualMaker.Bindings
{
    public partial class Bindings
    {
        public void On(InputActionReference inputActionReference, Action performed, Action started = null, Action canceled = null)
            => On(inputActionReference, _ => performed?.Invoke(), _ => started?.Invoke(), _ => canceled?.Invoke());

        public void Bind<T>(InputActionReference inputActionReference, Property<T> property) where T : struct
            => On<T>(inputActionReference, value => property.Value = value);

        public void Bind<T>(InputActionReference inputActionReference, Property<T> performed, Property<T> started, Property<T> canceled = null)
            where T : struct
        {
            On<T>(inputActionReference, value => performed.Value = value);

            if (started != null)
            {
                On<T>(inputActionReference, value => started.Value = value);
            }

            if (canceled != null)
            {
                On<T>(inputActionReference, value => canceled.Value = value);
            }
        }

        public void On<T>(InputActionReference inputActionReference, Action<T> performed, Action<T> started = null, Action<T> canceled = null)
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

            if (canceled != null)
            {
                inputAction.canceled += OnActionCanceled;
                AddUnsubscriber(() => inputAction.canceled -= OnActionCanceled);
            }

            return;
            void OnActionPerformed(InputAction.CallbackContext ctx) => performed(ctx.ReadValue<T>());
            void OnActionStarted(InputAction.CallbackContext ctx) => started(ctx.ReadValue<T>());
            void OnActionCanceled(InputAction.CallbackContext ctx) => canceled(ctx.ReadValue<T>());
        }

        public void On(InputActionReference inputActionReference, Action<InputAction.CallbackContext> performed, Action<InputAction.CallbackContext> started = null, Action<InputAction.CallbackContext> canceled = null)
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

            if (canceled != null)
            {
                inputAction.canceled += OnActionCanceled;
                AddUnsubscriber(() => inputAction.canceled -= OnActionCanceled);
            }

            return;
            void OnActionPerformed(InputAction.CallbackContext ctx) => performed(ctx);
            void OnActionStarted(InputAction.CallbackContext ctx) => started(ctx);
            void OnActionCanceled(InputAction.CallbackContext ctx) => canceled(ctx);
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

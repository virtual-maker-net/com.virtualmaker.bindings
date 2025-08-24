using UnityEngine;

namespace VirtualMaker.Bindings
{
    public class BindingMonoBehaviour : MonoBehaviour
    {
        private Bindings2 _bindings = new();
        protected Bindings2 Bindings => _bindings;

        protected virtual void OnEnable()
        {
            using var scope = _bindings.Scope();
            Bind();
        }

        protected virtual void OnDisable() => _bindings.Clear();

        protected virtual void Bind() {}
    }
}
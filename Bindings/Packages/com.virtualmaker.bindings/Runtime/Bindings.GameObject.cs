using System;
using UnityEngine;

namespace VirtualMaker.Bindings
{
    public partial class Bindings
    {
        public void BindActive(GameObject go, IProperty<bool> prop)
        {
            Bind(prop, value => go.SetActive(value));
        }

        public void BindActive<T>(GameObject go, IProperty<T> prop, Func<T, bool> transformer)
        {
            Bind(prop, value => go.SetActive(transformer(value)));
        }

        public void BindActive(Component component, IProperty<bool> prop)
        {
            Bind(prop, value => component.gameObject.SetActive(value));
        }

        public void BindActive<T>(Component component, IProperty<T> prop, Func<T, bool> transformer)
        {
            Bind(prop, value => component.gameObject.SetActive(transformer(value)));
        }
    }
}
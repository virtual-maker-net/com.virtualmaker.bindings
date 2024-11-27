using System;
using System.Collections.Generic;
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

        public void BindList<FromType, ToType>(Transform parent, ToType prefab, IProperty<List<FromType>> prop, Action<FromType, ToType> onTemplateAdded) where ToType : Component
        {
            var childItems = new Dictionary<FromType, ToType>();

            Action<List<FromType>> update = list =>
            {
                // Remove items that are no longer in the list.
                var removed = new List<FromType>();

                foreach (var (fromItem, toItem) in childItems)
                {
                    // In edit mode remove everything so we can test data changes
                    if (!list.Contains(fromItem) || !Application.isPlaying)
                    {
                        GameObject.Destroy(toItem.gameObject);
                        removed.Add(fromItem);
                    }
                }

                foreach (var item in removed)
                {
                    childItems.Remove(item);
                }

                // Add items that are new to the list.
                for (int i = 0; i < list.Count; i++)
                {
                    var item = list[i];
                    if (!childItems.TryGetValue(item, out var toItem))
                    {
                        toItem = GameObject.Instantiate(prefab, parent);
                        childItems.Add(item, toItem);
                        onTemplateAdded(item, toItem);
                    }

                    toItem.transform.SetSiblingIndex(i);
                }
            };

            prop.OnChange += update;

            _unsubscribe.Add(() =>
            {
                prop.OnChange -= update;

                foreach (var (_, toItem) in childItems)
                {
                    GameObject.Destroy(toItem.gameObject);
                }
            });

            update(prop.Value);
        }

    }
}
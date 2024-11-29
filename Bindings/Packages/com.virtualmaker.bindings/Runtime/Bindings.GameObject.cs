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

        public void BindList<TItem, TComponent>(Transform parent, TComponent prefab, IProperty<List<TItem>> prop, Action<TItem, TComponent> onPrefabAdded) where TComponent : Component
        {
            var childItems = new Dictionary<TItem, TComponent>();

            Action<List<TItem>> update = list =>
            {
                // Remove items that are no longer in the list.
                var removed = new List<TItem>();

                foreach (var (fromItem, toItem) in childItems)
                {
                    // In edit mode remove everything, so we can test data changes
                    if (!list.Contains(fromItem) || !Application.isPlaying)
                    {
                        toItem.gameObject.Destroy();
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
                        toItem = UnityEngine.Object.Instantiate(prefab, parent);
                        childItems.Add(item, toItem);
                        onPrefabAdded(item, toItem);
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
                    toItem.gameObject.Destroy();
                }
            });

            update(prop.Value);
        }
    }
}
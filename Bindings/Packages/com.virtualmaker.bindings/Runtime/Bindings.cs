using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UIElements;

namespace VirtualMaker.Bindings
{
    public class Bindings
    {
        private List<Action> _unsubscribe = new List<Action>();
        private VisualElement _root;

        public Bindings()
        {
        }

        public Bindings(VisualElement root)
        {
            _root = root;
        }

        public void BindText<T>(string name, IProperty<T> prop)
        {
            Bind<Label, T>(name, prop, (element, value) => element.text = value?.ToString());
        }

        public void BindText<T, W>(string name, IProperty<T> prop, Func<T, W> transform)
        {
            BindText(name, new Derived<T, W>(prop, transform));
        }

        public void BindDisplay(string name, bool fade, IProperty<bool> prop)
        {
            Bind<VisualElement, bool>(name, prop, async (element, value) =>
            {
                element.AddToClassList("fade-transition");

                if (value)
                {
                    element.style.display = DisplayStyle.Flex;
                    element.style.opacity = 1;
                }
                else
                {
                    element.style.opacity = 0;
                    if (fade)
                    {
                        await Task.Delay(200);
                    }
                    element.style.display = DisplayStyle.None;
                }
            });
        }

        public void BindDisplay<T>(string name, bool fade, IProperty<T> prop, Func<T, bool> transform)
        {
            BindDisplay(name, fade, new Derived<T, bool>(prop, transform));
        }

        public void BindImage(string name, IProperty<string> prop)
        {
            Bind<Image, string>(name, prop, async (element, value) =>
            {
                if (value.StartsWith("https://"))
                {
                    element.image = await ImageDownloader.GetOrCreate().DownloadImageAsync(value);
                }
            });
        }

        public void BindImage<T>(string name, IProperty<T> prop, Func<T, string> transform)
        {
            BindImage(name, new Derived<T, string>(prop, transform));
        }

        public void BindClass(string name, string className, IProperty<bool> prop)
        {
            Bind<VisualElement, bool>(name, prop, (element, value) =>
            {
                if (value)
                {
                    element.AddToClassList(className);
                }
                else
                {
                    element.RemoveFromClassList(className);
                }
            });
        }

        public void BindClass<T>(string name, string className, IProperty<T> prop, Func<T, bool> transform)
        {
            BindClass(name, className, new Derived<T, bool>(prop, transform));
        }

        public void BindPopup(string name, Property<bool> prop)
        {
            if (!TryGetElement<VisualElement>(name, out var element))
            {
                return;
            }

            // Flip property to false when clicking outside of popup.
            var clickToDismiss = new EventCallback<ClickEvent>(evt =>
            {
                if (element.worldBound.Contains(evt.position))
                {
                    return;
                }

                evt.PreventDefault();
                evt.StopImmediatePropagation();
                prop.Value = false;
            });

            Bind(prop, (value) =>
            {
                if (value)
                {
                    _root.RegisterCallback<ClickEvent>(clickToDismiss, TrickleDown.TrickleDown);
                }
                else
                {
                    _root.UnregisterCallback<ClickEvent>(clickToDismiss, TrickleDown.TrickleDown);
                }
            });

            // Show/hide popup when property changes.
            BindDisplay(name, true, prop);
        }

        public void Bind<T>(IProperty<T> prop, Action<T> action)
        {
            prop.OnChange += action;
            _unsubscribe.Add(() => prop.OnChange -= action);
            action(prop.Value);
        }

        public void Bind<V, T>(string name, IProperty<T> prop, Action<V, T> action) where V : VisualElement
        {
            if (TryGetElement<V>(name, out var element))
            {
                Bind(prop, v => action(element, v));
            }
        }

        public void OnClick(string name, Action action)
        {
            if (TryGetElement<Button>(name, out var element))
            {
                var cb = new EventCallback<ClickEvent>(_ => action());
                _unsubscribe.Add(() => element.UnregisterCallback<ClickEvent>(cb));
                element.RegisterCallback<ClickEvent>(cb);
            }
        }

        private bool TryGetElement<T>(string name, out T element) where T : VisualElement
        {
            element = null;
            if (_root == null)
            {
                return false; // Seems to happen on play in editor.
            }

            element = _root.Q<T>(name);
            if (element == null)
            {
                throw new Exception("Can't bind to unknown element: " + name);
            }

            return true;
        }

        public void Reset()
        {
            foreach (var unsubscribe in _unsubscribe)
            {
                unsubscribe();
            }

            _unsubscribe.Clear();
        }
    }
}
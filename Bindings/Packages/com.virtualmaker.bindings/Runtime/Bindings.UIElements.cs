#if UNITY_UI_ELEMENTS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UIElements;

namespace VirtualMaker.Bindings
{
    public partial class Bindings
    {
        private readonly VisualElement _root;
        public VisualElement Root => _root;

        public Bindings(VisualElement root)
        {
            _root = root;
        }

        public void BindText<T>(string name, IProperty<T> prop)
        {
            if (TryGetElement<TextElement>(name, out var element))
            {
                BindText(element, prop);
            }
        }

        public void BindText<T>(TextElement element, IProperty<T> prop)
        {
            Bind(element, prop, SetText);
        }

        public void BindText<T, W>(string name, IProperty<T> prop, Func<T, W> transform)
        {
            BindText(name, Derived.From(prop, transform));
        }

        public void BindText<T, W>(TextElement element, IProperty<T> prop, Func<T, W> transform)
        {
            BindText(element, Derived.From(prop, transform));
        }

        public void SetText<T>(string name, T value)
        {
            if (TryGetElement<TextElement>(name, out var element))
            {
                SetText(element, value);
            }
        }

        public void SetText<T>(TextElement element, T value)
        {
            element.text = value?.ToString();
        }

        public void SetLineHeight(string name, int lineHeight)
        {
            if (TryGetElement<Label>(name, out var element))
            {
                element.text = $"<line-height={lineHeight}px>{element.text}";
            }
        }

        public void BindWidth(string name, IProperty<StyleLength> prop)
        {
            Bind<VisualElement, StyleLength>(name, prop, (element, value) => element.style.width = value);
        }

        public void BindWidth<T>(string name, IProperty<T> prop, Func<T, StyleLength> transform)
        {
            BindWidth(name, Derived.From(prop, transform));
        }

        public void SetWidth(string name, StyleLength value)
        {
            if (TryGetElement<VisualElement>(name, out var element))
            {
                element.style.width = value;
            }
        }

        private async void SetDisplay(VisualElement element, bool value, bool fade)
        {
            if (element.style.opacity == 0 && !value)
            {
                return;
            }

            if (element.style.opacity == 1 && value)
            {
                return;
            }

            if (fade)
            {
                element.AddToClassList("fade-transition");
            }

            element.style.opacity = value ? 1 : 0;

            if (value)
            {
                element.style.display = DisplayStyle.Flex;
            }

            if (fade)
            {
                await Task.Delay(200).ConfigureAwait(true);
            }

            if (!value && element.style.opacity == 0)
            {
                element.style.display = DisplayStyle.None;
            }
        }

        public void SetDisplay(string name, bool value, bool fade = false)
        {
            if (TryGetElement<VisualElement>(name, out var element))
            {
                SetDisplay(element, value, fade);
            }
        }

        public void BindDisplay(string name, bool fade, IProperty<bool> prop)
        {
            Bind<VisualElement, bool>(name, prop, (element, value) => SetDisplay(element, value, fade));
        }

        public void BindDisplay<T>(string name, bool fade, IProperty<T> prop, Func<T, bool> transform)
        {
            BindDisplay(name, fade, Derived.From(prop, transform));
        }

        private void SetImage(Image element, VectorImage vectorImage)
        {
            element.vectorImage = vectorImage;
        }

        private void SetImage(Image element, Texture texture)
        {
            element.image = texture;
        }

        private async void SetImage(Image element, string url)
        {
            element.image = null;

            if (!string.IsNullOrWhiteSpace(url) &&
                url.StartsWith("https://"))
            {
                var texture = await DownloadImageAsync(url);
                if (texture != null)
                {
                    element.image = texture;
                }
            }
        }

        public void SetImage(string name, string url)
        {
            if (TryGetElement<Image>(name, out var element))
            {
                SetImage(element, url);
            }
        }

        public void SetImage(string name, Texture2D value)
        {
            if (TryGetElement<Image>(name, out var element))
            {
                SetImage(element, value);
            }
        }

        public void SetImage(string name, VectorImage value)
        {
            if (TryGetElement<Image>(name, out var element))
            {
                SetImage(element, value);
            }
        }

        private void SetBackgroundImage(VisualElement element, VectorImage vectorImage)
        {
            element.style.backgroundImage = Background.FromVectorImage(vectorImage);
        }

        private void SetBackgroundImage(VisualElement element, Texture2D texture)
        {
            element.style.backgroundImage = Background.FromTexture2D(texture);
        }

        private async void SetBackgroundImage(VisualElement element, string url)
        {
            element.style.backgroundImage = null;

            if (!string.IsNullOrWhiteSpace(url) &&
                url.StartsWith("https://"))
            {
                var texture = await DownloadImageAsync(url);
                if (texture != null)
                {
                    element.style.backgroundImage = Background.FromTexture2D(texture);
                }
            }
        }

        public void SetBackgroundImage(string name, string url)
        {
            if (TryGetElement<VisualElement>(name, out var element))
            {
                SetBackgroundImage(element, url);
            }
        }

        public void SetBackgroundImage(string name, VectorImage value)
        {
            if (TryGetElement<VisualElement>(name, out var element))
            {
                SetBackgroundImage(element, value);
            }
        }

        public void SetBackgroundColor(string name, Color color)
        {
            if (TryGetElement<VisualElement>(name, out var element))
            {
                element.style.backgroundColor = color;
            }
        }

        public void BindImage<T>(string name, IProperty<T> prop, Func<T, string> transform)
        {
            BindImage(name, Derived.From(prop, transform));
        }

        public void BindImage(string name, IProperty<string> prop)
        {
            Bind<Image, string>(name, prop, SetImage);
        }

        public void BindImage(string name, IProperty<VectorImage> prop)
        {
            Bind<Image, VectorImage>(name, prop, SetImage);
        }

        public void BindImage(string name, IProperty<Texture2D> prop)
        {
            Bind<Image, Texture2D>(name, prop, SetImage);
        }

        public void BindImage(string name, IProperty<Texture> prop)
        {
            Bind<Image, Texture>(name, prop, SetImage);
        }

        public void BindBackgroundImage<T>(string name, IProperty<T> prop, Func<T, string> transform)
        {
            BindBackgroundImage(name, Derived.From(prop, transform));
        }

        public void BindBackgroundImage(string name, IProperty<string> prop)
        {
            Bind<VisualElement, string>(name, prop, SetBackgroundImage);
        }

        public void BindBackgroundImage(string name, IProperty<VectorImage> prop)
        {
            Bind<VisualElement, VectorImage>(name, prop, SetBackgroundImage);
        }

        public void BindBackgroundImage(string name, IProperty<Texture2D> prop)
        {
            Bind<VisualElement, Texture2D>(name, prop, SetBackgroundImage);
        }

        public void BindTextField(string name, Property<string> prop, bool twoWay)
        {
            if (TryGetElement<TextField>(name, out var element))
            {
                BindTextField(element, prop, twoWay);
            }
        }

        private void BindTextField(TextField textField, Property<string> property, bool twoWay)
        {
            Bind(property, value => textField.value = value);

            if (twoWay)
            {
                On<ChangeEvent<string>>(textField, e => property.Value = e.newValue);
            }
        }

#if UNITY_2022_1_OR_NEWER
        public void BindField<T>(string name, Property<T> property, bool twoWay)
        {
            if (TryGetElement<BaseField<T>>(name, out var element))
            {
                BindField<T>(element, property, twoWay);
            }
        }

        public void BindField<T>(BaseField<T> baseField, Property<T> property, bool twoWay)
        {
            Bind(property, value => baseField.value = value);

            if (twoWay)
            {
                On<ChangeEvent<T>>(baseField, e => property.Value = e.newValue);
            }
        }

        public void BindField<T>(string name, T value, Action<T> onChange)
        {
            if (TryGetElement<BaseField<T>>(name, out var baseField))
            {
                baseField.value = value;
                On<ChangeEvent<T>>(baseField, e => onChange(e.newValue));
            }
        }
#endif // UNITY_2022_1_OR_NEWER

        public void SetClass(VisualElement element, string className, bool value)
        {
            if (value)
            {
                element.AddToClassList(className);
            }
            else
            {
                element.RemoveFromClassList(className);
            }
        }

        public void SetClass(string name, string className, bool value)
        {
            if (TryGetElement<VisualElement>(name, out var element))
            {
                SetClass(element, className, value);
            }
        }

        public void BindClass(string name, string className, IProperty<bool> prop)
        {
            Bind<VisualElement, bool>(name, prop, (element, value) => SetClass(element, className, value));
        }

        public void BindClass<T>(string name, string className, IProperty<T> prop, Func<T, bool> transform)
        {
            BindClass(name, className, Derived.From(prop, transform));
        }

        public void BindEnabled(string name, IProperty<bool> prop)
        {
            Bind<VisualElement, bool>(name, prop, (element, value) =>
            {
                element.SetEnabled(value);
            });
        }

        public void BindEnabled<T>(string name, IProperty<T> prop, Func<T, bool> transform)
        {
            BindEnabled(name, Derived.From(prop, transform));
        }

        public void BindEnabled(string name, params IProperty<bool>[] props)
        {
            var enabledProp = new Property<bool>();

            foreach (var prop in props)
            {
                Bind(prop, OnPropValueChanged);
            }

            BindEnabled(name, enabledProp);

            void OnPropValueChanged(bool newValue)
            {
                enabledProp.Value = props.All(prop => prop.Value);
            }
        }

        public void BindPopup(string name, Property<bool> prop)
        {
            if (!TryGetElement<VisualElement>(name, out var element))
            {
                return;
            }

            // Flip property to false when clicking outside the popup.
            var clickToDismiss = new EventCallback<ClickEvent>(evt =>
            {
                if (element.worldBound.Contains(evt.position))
                {
                    return;
                }
#if !UNITY_6000_0_OR_NEWER
                evt.PreventDefault();
#endif // !UNITY_6000_0_OR_NEWER
                evt.StopImmediatePropagation();
                prop.Value = false;
            });

            Bind(prop, value =>
            {
                if (value)
                {
                    _root.RegisterCallback(clickToDismiss, TrickleDown.TrickleDown);
                }
                else
                {
                    _root.UnregisterCallback(clickToDismiss, TrickleDown.TrickleDown);
                }
            });

            // Show/hide popup when property changes.
            BindDisplay(name, true, prop);
        }

        public IReadOnlyDictionary<T, Bindings> BindList<T>(string containerName, VisualTreeAsset template, IProperty<List<T>> prop, Action<T, Bindings> onTemplateAdded)
        {
            var childItems = new Dictionary<T, Bindings>();

            if (!TryGetElement<VisualElement>(containerName, out var container))
            {
                return childItems;
            }

            Action<List<T>> update = list =>
            {
                // Remove items that are no longer in the list.
                var removed = new List<T>();

                foreach (var (item, bindings) in childItems)
                {
                    // In edit mode remove everything, so we can test data changes
                    if (!list.Contains(item) || !Application.isPlaying)
                    {
                        bindings.Reset();
                        bindings._root.RemoveFromHierarchy();
                        removed.Add(item);
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
                    if (!childItems.TryGetValue(item, out var bindings))
                    {
                        var newItem = template.CloneTree();
                        bindings = new Bindings(newItem);
                        childItems.Add(item, bindings);
                        onTemplateAdded(item, bindings);
                    }

                    container.Insert(i, bindings._root);
                }
            };

            prop.OnChange += update;

            _unsubscribe.Add(() =>
            {
                foreach (var (_, bindings) in childItems)
                {
                    bindings.Reset();
                }

                prop.OnChange -= update;
            });

            update(prop.Value);
            return childItems;
        }

        public IReadOnlyDictionary<K, Bindings> BindDictionary<K, V>(string containerName, VisualTreeAsset template, IProperty<Dictionary<K, V>> prop, Action<K, V, Bindings> onTemplateAdded)
        {
            var childItems = new Dictionary<K, Bindings>();

            if (!TryGetElement<VisualElement>(containerName, out var container))
            {
                return childItems;
            }

            Action<Dictionary<K, V>> update = dict =>
            {
                // Remove items that are no longer in the dict.
                var removed = new List<K>();

                foreach (var (key, bindings) in childItems)
                {
                    // In edit mode remove everything, so we can test data changes
                    if (!dict.ContainsKey(key) || !Application.isPlaying)
                    {
                        bindings.Reset();
                        bindings._root.RemoveFromHierarchy();
                        removed.Add(key);
                    }
                }

                foreach (var item in removed)
                {
                    childItems.Remove(item);
                }

                // Add items that are new to the list.
                foreach (var (key, value) in dict)
                {
                    if (!childItems.TryGetValue(key, out var bindings))
                    {
                        var newItem = template.CloneTree();
                        bindings = new Bindings(newItem);
                        childItems.Add(key, bindings);
                        onTemplateAdded(key, value, bindings);
                    }

                    container.Add(bindings._root);
                }
            };

            prop.OnChange += update;

            _unsubscribe.Add(() =>
            {
                foreach (var (_, bindings) in childItems)
                {
                    bindings.Reset();
                }

                prop.OnChange -= update;
            });

            update(prop.Value);
            return childItems;
        }

        public void Bind<TElement, T>(string name, IProperty<T> prop, Action<TElement, T> action)
            where TElement : VisualElement
        {
            if (TryGetElement<TElement>(name, out var element))
            {
                Bind(prop, v => action(element, v));
            }
        }

        public void Bind<TElement, T>(TElement element, IProperty<T> prop, Action<TElement, T> action)
            where TElement : VisualElement
        {
            Bind(prop, v => action(element, v));
        }

        public void Set<T>(string name, Action<T> action) where T : VisualElement
        {
            if (TryGetElement<T>(name, out var element))
            {
                action(element);
            }
        }

        public void OnClick(string name, Action action)
        {
            if (TryGetElement<Button>(name, out var element))
            {
                OnClick(element, action);
            }
        }

        public void OnClick<T>(string name, Action action, IProperty<T> canExecuteProp, Func<T, bool> transform)
        {
            OnClick(name, action, Derived.From(canExecuteProp, transform));
        }

        public void OnClick(string name, Action action, IProperty<bool> canExecute)
        {
            if (TryGetElement<Button>(name, out var button))
            {
                Bind(canExecute, value => button.SetEnabled(value));
                OnClick(button, action);
            }
        }

        public void OnClick(string name, Action action, params IProperty<bool>[] canExecuteProps)
        {
            if (TryGetElement<Button>(name, out var button))
            {
                BindEnabled(name, canExecuteProps);
                OnClick(button, action);
            }
        }

        public void OnScrollToBottom(string name, Action action)
        {
            if (TryGetElement<ScrollView>(name, out var element))
            {
                var cb = new Action<float>(value =>
                {
                    if ((int)element.verticalScroller.highValue == (int)value)
                    {
                        action();
                    }
                });

                element.verticalScroller.valueChanged += cb;
                _unsubscribe.Add(() => element.verticalScroller.valueChanged -= cb);
            }
        }

        public bool TryGetElement<T>(string name, out T element) where T : VisualElement
        {
            element = null;

            if (_root == null)
            {
                return false; // Seems to happen on play in editor.
            }

            VisualElement visualElement;

            if (name.StartsWith('/'))
            {
                if (!TryGetElementByPath(name, _root, out visualElement))
                {
                    return false;
                }
            }
            else
            {
                visualElement = _root.Q<VisualElement>(name);
            }

            switch (visualElement)
            {
                case null:
                    Debug.LogError($"Element '{name}' not found.");
                    return false;
                case T result:
                    element = result;
                    return true;
                default:
                    Debug.LogError($"Cannot cast '{visualElement.name}' to type {typeof(T).Name}.");
                    return false;
            }
        }

        private static bool TryGetElementByPath(string path, VisualElement root, out VisualElement visualElement)
        {
            var elements = path.Split('/');
            var parent = root;

            visualElement = null;

            for (var i = 1; i < elements.Length; i++)
            {
                var elementName = elements[i];

                if (string.IsNullOrWhiteSpace(elementName))
                {
                    Debug.LogError($"Invalid path: {path}. Element name cannot be null or empty.");
                    return false;
                }

                visualElement = new UQueryBuilder<VisualElement>(parent).Name(elementName);

                if (visualElement is null)
                {
                    Debug.LogError($"Element '{elementName}' not found.");
                    return false;
                }

                parent = visualElement;
            }

            return true;
        }

        private void OnClick(CallbackEventHandler element, Action action, bool stopImmediatePropagation = true)
        {
            On(element, new EventCallback<ClickEvent>(e =>
            {
                if (stopImmediatePropagation)
                {
                    e.StopImmediatePropagation();
                }

                action();
            }));
        }

        /// <summary>
        /// Safely register callback, which will also safely unsubscribe event when <see cref="Reset"/> is called.
        /// </summary>
        /// <typeparam name="TEvent"></typeparam>
        /// <param name="element">The element to get callbacks for.</param>
        /// <param name="callback"><see cref="EventCallback{TEventType}"/></param>
        /// <param name="useTrickleDown"><see cref="TrickleDown"/></param>
        public void On<TEvent>(
            CallbackEventHandler element,
            EventCallback<TEvent> callback,
            TrickleDown useTrickleDown = TrickleDown.NoTrickleDown)
                where TEvent : EventBase<TEvent>, new()
        {
            element.RegisterCallback(callback, useTrickleDown);
            _unsubscribe.Add(() => element.UnregisterCallback(callback));
        }
    }
}

#endif // UNITY_UI_ELEMENTS
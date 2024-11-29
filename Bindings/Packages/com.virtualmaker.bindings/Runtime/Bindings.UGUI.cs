#if UNITY_UGUI

using System;
#if UNITY_TMPRO
using TMPro;
#endif // UNITY_TMPRO
using UnityEngine;
using UnityEngine.UI;

namespace VirtualMaker.Bindings
{
    public partial class Bindings
    {
#if UNITY_TMPRO
        public void BindText(TMP_Text text, IProperty<string> prop)
        {
            Bind(prop, value => text.text = value);
        }

        public void BindText<T>(TMP_Text text, IProperty<T> prop, Func<T, string> transformer)
        {
            Bind(prop, value => text.text = transformer(value));
        }

        public void BindTextColor(TMP_Text text, IProperty<Color> prop)
        {
            Bind(prop, value => text.color = value);
        }

        public void BindTextColor<T>(TMP_Text text, IProperty<T> prop, Func<T, Color> transformer)
        {
            Bind(prop, value => text.color = transformer(value));
        }
#endif // UNITY_TMPRO


        public void BindImageColor(Image image, IProperty<Color> prop)
        {
            Bind(prop, value => image.color = value);
        }

        public void BindImageColor<T>(Image image, IProperty<T> prop, Func<T, Color> transformer)
        {
            Bind(prop, value => image.color = transformer(value));
        }

        public void BindImageFill(Image image, IProperty<float> prop)
        {
            Bind(prop, value => image.fillAmount = value);
        }

        public void BindImageFill<T>(Image image, IProperty<T> prop, Func<T, float> transformer)
        {
            Bind(prop, value => image.fillAmount = transformer(value));
        }
    }
}

#endif // UNITY_UGUI
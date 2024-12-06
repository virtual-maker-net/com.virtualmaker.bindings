using UnityEngine;

namespace VirtualMaker.Bindings
{
    public partial class Bindings
    {
        public void BindPlayerPref(string key, Property<float> prop, bool getFromPref, float? defaultValue = null)
        {
            if (getFromPref)
            {
                prop.Value = PlayerPrefs.GetFloat(key, defaultValue ?? prop.Value);
            }
            BindPlayerPref(key, prop);
        }

        public void BindPlayerPref(string key, IProperty<float> prop)
        {
            Bind(prop, value => PlayerPrefs.SetFloat(key, value));
            SavePrefsOnReset();
        }

        public void BindPlayerPref(string key, Property<int> prop, bool getFromPref, int? defaultValue = null)
        {
            if (getFromPref)
            {
                prop.Value = PlayerPrefs.GetInt(key, defaultValue ?? prop.Value);
            }
            BindPlayerPref(key, prop);
        }

        public void BindPlayerPref(string key, IProperty<int> prop)
        {
            Bind(prop, value => PlayerPrefs.SetInt(key, value));
            SavePrefsOnReset();
        }

        public void BindPlayerPref(string key, Property<string> prop, bool getFromPref, string defaultValue)
        {
            if (getFromPref)
            {
                prop.Value = PlayerPrefs.GetString(key, defaultValue);
            }
            BindPlayerPref(key, prop);
        }

        public void BindPlayerPref(string key, Property<string> prop, bool getFromPref)
        {
            if (getFromPref)
            {
                prop.Value = PlayerPrefs.GetString(key, prop.Value);
            }
            BindPlayerPref(key, prop);
        }

        public void BindPlayerPref(string key, IProperty<string> prop)
        {
            Bind(prop, value => PlayerPrefs.SetString(key, value));
            SavePrefsOnReset();
        }

        private void SavePrefsOnReset()
        {
            if (!_unsubscribe.Contains(PlayerPrefs.Save))
            {
                AddUnsubscriber(PlayerPrefs.Save);
            }
        }
    }
}
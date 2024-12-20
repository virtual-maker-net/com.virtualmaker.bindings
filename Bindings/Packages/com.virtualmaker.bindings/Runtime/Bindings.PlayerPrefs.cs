using UnityEngine;

namespace VirtualMaker.Bindings
{
    public partial class Bindings
    {
        /// <summary> Binds player pref to property. </summary>
        /// <param name="key"> Key used by <c>PlayerPrefs</c> to get and set the value. </param>
        /// <param name="prop"> <c>Property</c> that gets the stored value then sets it when changed. </param>
        /// <param name="defaultValue"> Value to set <c>prop.Value</c> to if a value isn't found. </param>
        public void BindPlayerPref(string key, Property<float> prop, float defaultValue)
        {
            if (getFromPref)
            {
                prop.Value = PlayerPrefs.GetFloat(key, defaultValue);
            }
            BindPlayerPref(key, prop);
        }

        /// <summary> Binds player pref to property. </summary>
        /// <param name="key"> Key used by <c>PlayerPrefs</c> to set the value. </param>
        /// <param name="prop"> <c>IProperty</c> that sets the value. </param>
        public void BindPlayerPref(string key, IProperty<float> prop)
        {
            Bind(prop, value => PlayerPrefs.SetFloat(key, value));
        }

        /// <summary> Binds player pref to property. </summary>
        /// <param name="key"> Key used by <c>PlayerPrefs</c> to get and set the value. </param>
        /// <param name="prop"> <c>Property</c> that gets the stored value then sets it when changed. </param>
        /// <param name="defaultValue"> Value to set <c>prop.Value</c> to if a value isn't found. </param>
        public void BindPlayerPref(string key, Property<int> prop, int defaultValue)
        {
            if (getFromPref)
            {
                prop.Value = PlayerPrefs.GetInt(key, defaultValue);
            }
            BindPlayerPref(key, prop);
        }

        /// <summary> Binds player pref to property. </summary>
        /// <param name="key"> Key used by <c>PlayerPrefs</c> to set the value. </param>
        /// <param name="prop"> <c>IProperty</c> that sets the value. </param>
        public void BindPlayerPref(string key, IProperty<int> prop)
        {
            Bind(prop, value => PlayerPrefs.SetInt(key, value));
        }

        /// <summary> Binds player pref to property. </summary>
        /// <param name="key"> Key used by <c>PlayerPrefs</c> to get and set the value. </param>
        /// <param name="prop"> <c>Property</c> that gets the stored value then sets it when changed. </param>
        /// <param name="defaultValue"> Value to set <c>prop.Value</c> to if a value isn't found. </param>
        public void BindPlayerPref(string key, Property<string> prop, string defaultValue)
        {
            if (getFromPref)
            {
                prop.Value = PlayerPrefs.GetString(key, defaultValue);
            }
            BindPlayerPref(key, prop);
        }

        /// <summary> Binds player pref to property. </summary>
        /// <param name="key"> Key used by <c>PlayerPrefs</c> to set the value. </param>
        /// <param name="prop"> <c>IProperty</c> that sets the value. </param>
        public void BindPlayerPref(string key, IProperty<string> prop)
        {
            Bind(prop, value => PlayerPrefs.SetString(key, value));
        }
    }
}
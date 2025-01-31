using UnityEngine;

namespace VirtualMaker.Bindings
{
    public partial class Bindings
    {
        /// <summary> Assigns property to saved player pref, then binds player pref to be set by the property. </summary>
        /// <param name="key"> Key used by <c>PlayerPrefs</c> to set the value. </param>
        /// <param name="prop"> <c>Property</c> that sets the value. </param>
        /// <param name="defaultValue"> Optional: Value to set <c>prop.Value</c> to if a value isn't found. </param>
        public void GetAndBindPlayerPref(string key, Property<float> prop, float defaultValue = 0)
        {
            prop.Value = PlayerPrefs.GetFloat(key, defaultValue);
            BindDeferred(prop, value => PlayerPrefs.SetFloat(key, value));
        }

        /// <summary> Binds player pref to be set by an <c>IProperty</c>. </summary>
        /// <param name="key"> Key used by <c>PlayerPrefs</c> to set the value. </param>
        /// <param name="prop"> <c>IProperty</c> that sets the value. </param>
        public void BindPlayerPref(string key, IProperty<float> prop)
        {
            Bind(prop, value => PlayerPrefs.SetFloat(key, value));
        }

        /// <summary> Assigns property to saved player pref, then binds player pref to be set by the property. </summary>
        /// <param name="key"> Key used by <c>PlayerPrefs</c> to set the value. </param>
        /// <param name="prop"> <c>Property</c> that sets the value. </param>
        /// <param name="defaultValue"> Optional: Value to set <c>prop.Value</c> to if a value isn't found. </param>
        public void GetAndBindPlayerPref(string key, Property<int> prop, int defaultValue = 0)
        {
            prop.Value = PlayerPrefs.GetInt(key, defaultValue);
            BindDeferred(prop, value => PlayerPrefs.SetInt(key, value));
        }

        /// <summary> Binds player pref to be set by an <c>IProperty</c>. </summary>
        /// <param name="key"> Key used by <c>PlayerPrefs</c> to set the value. </param>
        /// <param name="prop"> <c>IProperty</c> that sets the value. </param>
        public void BindPlayerPref(string key, IProperty<int> prop)
        {
            Bind(prop, value => PlayerPrefs.SetInt(key, value));
        }

        /// <summary> Assigns property to saved player pref, then binds player pref to be set by the property. </summary>
        /// <param name="key"> Key used by <c>PlayerPrefs</c> to set the value. </param>
        /// <param name="prop"> <c>Property</c> that sets the value. </param>
        /// <param name="defaultValue"> Optional: Value to set <c>prop.Value</c> to if a value isn't found. </param>
        public void GetAndBindPlayerPref(string key, Property<string> prop, string defaultValue = "")
        {
            prop.Value = PlayerPrefs.GetString(key, defaultValue);
            BindDeferred(prop, value => PlayerPrefs.SetString(key, value));
        }

        /// <summary> Binds player pref to be set by an <c>IProperty</c>. </summary>
        /// <param name="key"> Key used by <c>PlayerPrefs</c> to set the value. </param>
        /// <param name="prop"> <c>IProperty</c> that sets the value. </param>
        public void BindPlayerPref(string key, IProperty<string> prop)
        {
            Bind(prop, value => PlayerPrefs.SetString(key, value));
        }
    }
}

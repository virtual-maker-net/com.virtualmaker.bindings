using UnityEngine;

namespace VirtualMaker.Bindings
{
    public partial class Bindings
    {
        /// <summary> Binds player pref to property. </summary>
        /// <param name="key"> Key used by <c>PlayerPrefs</c> to get and set the value. </param>
        /// <param name="prop"> Property that sets the value. </param>
        /// <param name="getFromPref"> Whether to try setting <c>prop.Value</c> to the value already inside the <c>PlayerPrefs</c>. </param>
        /// <param name="defaultValue"> Value to set <c>prop.Value</c> to if <c>getFromPref</c> is <c>true</c> but there isn't a value already inside the <c>PlayerPref</c>. </param>
        public void BindPlayerPref(string key, Property<float> prop, bool getFromPref, float? defaultValue = null)
        {
            if (getFromPref)
            {
                prop.Value = PlayerPrefs.GetFloat(key, defaultValue ?? prop.Value);
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
        /// <param name="prop"> Property that sets the value. </param>
        /// <param name="getFromPref"> Whether to try setting <c>prop.Value</c> to the value already inside the <c>PlayerPrefs</c>. </param>
        /// <param name="defaultValue"> Value to set <c>prop.Value</c> to if <c>getFromPref</c> is <c>true</c> but there isn't a value already inside the <c>PlayerPref</c>. </param>
        public void BindPlayerPref(string key, Property<int> prop, bool getFromPref, int? defaultValue = null)
        {
            if (getFromPref)
            {
                prop.Value = PlayerPrefs.GetInt(key, defaultValue ?? prop.Value);
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
        /// <param name="prop"> Property that sets the value. </param>
        /// <param name="getFromPref"> Whether to try setting <c>prop.Value</c> to the value already inside the <c>PlayerPrefs</c>. </param>
        /// <param name="defaultValue"> Value to set <c>prop.Value</c> to if <c>getFromPref</c> is <c>true</c> but there isn't a value already inside the <c>PlayerPref</c>. </param>
        public void BindPlayerPref(string key, Property<string> prop, bool getFromPref, string defaultValue)
        {
            if (getFromPref)
            {
                prop.Value = PlayerPrefs.GetString(key, defaultValue);
            }
            BindPlayerPref(key, prop);
        }

        /// <summary> Binds player pref to property. </summary>
        /// <param name="key"> Key used by <c>PlayerPrefs</c> to get and set the value. </param>
        /// <param name="prop"> Property that sets the value. </param>
        /// <param name="getFromPref"> Whether to try setting <c>prop.Value</c> to the value already inside the <c>PlayerPrefs</c>. </param>
        public void BindPlayerPref(string key, Property<string> prop, bool getFromPref)
        {
            if (getFromPref)
            {
                prop.Value = PlayerPrefs.GetString(key, prop.Value);
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
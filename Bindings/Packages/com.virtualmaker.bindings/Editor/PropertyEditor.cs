using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;

namespace VirtualMaker.Bindings.Editor
{
    [CustomPropertyDrawer(typeof(Property<>), true)]
    public class PropertyEditor : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var value = property?.FindPropertyRelative("_value");
            if (value == null)
            {
                return EditorGUIUtility.singleLineHeight;
            }

            return EditorGUI.GetPropertyHeight(value, label, true);
        }

        // https://discussions.unity.com/t/get-the-instance-the-serializedproperty-belongs-to-in-a-custompropertydrawer/66954
        protected static object GetParent(SerializedProperty prop)
        {
            var path = prop.propertyPath.Replace(".Array.data[", "[");
            object obj = prop.serializedObject.targetObject;
            var elements = path.Split('.');
            foreach (var element in elements.Take(elements.Length - 1))
            {
                if (element.Contains("["))
                {
                    var elementName = element.Substring(0, element.IndexOf("["));
                    var index = Convert.ToInt32(element.Substring(element.IndexOf("[")).Replace("[", "").Replace("]", ""));
                    obj = GetValue(obj, elementName, index);
                }
                else
                {
                    obj = GetValue(obj, element);
                }
            }

            return obj;
        }

        private static object GetValue(object source, string name)
        {
            if (source == null)
            {
                return null;
            }

            var type = source.GetType();
            var f = type.GetField(name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            if (f == null)
            {
                var p = type.GetProperty(name, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);
                if (p == null)
                {
                    return null;
                }

                return p.GetValue(source, null);
            }

            return f.GetValue(source);
        }

        private static object GetValue(object source, string name, int index)
        {
            var enumerable = GetValue(source, name) as IEnumerable;
            var enm = enumerable.GetEnumerator();
            while (index-- >= 0)
            {
                enm.MoveNext();
            }

            return enm.Current;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var value = property?.FindPropertyRelative("_value");
            if (value == null)
            {
                return;
            }

            property.serializedObject.Update();

            EditorGUI.PropertyField(position, value, label, true);

            if (property.serializedObject.ApplyModifiedProperties())
            {
                var parent = GetParent(property);
                var prop = fieldInfo.GetValue(parent);
                if (prop is IPropertyNotify propertyNotify)
                {
                    propertyNotify.NotifyChanged();
                }
            }
        }
    }
}
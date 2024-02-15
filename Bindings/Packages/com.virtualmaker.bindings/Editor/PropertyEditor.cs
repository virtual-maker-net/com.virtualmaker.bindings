using UnityEditor;
using UnityEngine;

namespace VirtualMaker.Bindings
{
    [CustomPropertyDrawer(typeof(Property<>), true)]
    public class PropertyEditor : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return EditorGUI.GetPropertyHeight(property.FindPropertyRelative("_value"), label, true);
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.PropertyField(position, property.FindPropertyRelative("_value"), label, true);

            if (property.serializedObject.ApplyModifiedProperties())
            {
                var target = fieldInfo.GetValue(property.serializedObject.targetObject) as IPropertyNotify;
                target?.NotifyChanged();
            }
        }
    }
}
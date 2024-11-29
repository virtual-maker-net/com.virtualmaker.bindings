#if UNITY_NETCODE_GAMEOBJECTS
using UnityEditor;
using UnityEngine;

namespace VirtualMaker.Bindings.Editor
{
    [CustomPropertyDrawer(typeof(NetworkProperty<>), true)]
    public class NetworkPropertyEditor : PropertyEditor
    {
        private const string k_InternalValue = "m_InternalValue";

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var value = property?.FindPropertyRelative(k_InternalValue);
            return value == null ? EditorGUIUtility.singleLineHeight : EditorGUI.GetPropertyHeight(value, label, true);
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var value = property?.FindPropertyRelative(k_InternalValue);
            if (value == null) { return; }

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
#endif // UNITY_NETCODE_GAMEOBJECTS
#if UNITY_NETCODE_GAMEOBJECTS
using UnityEditor;
using UnityEngine;

namespace VirtualMaker.Bindings.Netcode.Editor
{
    [CustomPropertyDrawer(typeof(NetworkProperty<>), true)]
    public class NetworkPropertyEditor : PropertyEditor
    {
        private const string m_InternalValue = nameof(m_InternalValue);

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            var value = property?.FindPropertyRelative(nameof(m_InternalValue));
            return value == null ? EditorGUIUtility.singleLineHeight : EditorGUI.GetPropertyHeight(value, label, true);
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var value = property?.FindPropertyRelative(nameof(m_InternalValue));
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
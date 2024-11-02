using UnityEditor;
using UnityEngine;

namespace VirtualMaker.Bindings.Editor
{
    [CustomPropertyDrawer(typeof(PropertyRangeAttribute), true)]
    public class PropertyRangeAttributeEditor : PropertyEditor
    {
        private static string s_InvalidTypeMessage = L10n.Tr("Use Range with float or int.");

        protected override void OnGUIValue(Rect position, SerializedProperty value, GUIContent label)
        {
            PropertyRangeAttribute range = (PropertyRangeAttribute)attribute;
            if (value.propertyType == SerializedPropertyType.Float)
                EditorGUI.Slider(position, value, range.min, range.max, label);
            else if (value.propertyType == SerializedPropertyType.Integer)
                EditorGUI.IntSlider(position, value, (int)range.min, (int)range.max, label);
            else
                EditorGUI.LabelField(position, label.text, s_InvalidTypeMessage);
        }
    }
}
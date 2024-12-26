using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace VirtualMaker.Bindings.Editor
{
    [CustomPropertyDrawer(typeof(RangeAttribute))]
    public class RangeAttributeDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            if (attribute is not RangeAttribute rangeAttribute) { return; }
            var valueProperty = property.FindPropertyRelative("_value") ?? // vanilla property backing field
                property.FindPropertyRelative("m_InternalValue") ?? // network property backing field
                property; // vanilla property

            switch (valueProperty.propertyType)
            {
                case SerializedPropertyType.Float:
                    EditorGUI.Slider(position, valueProperty, rangeAttribute.min, rangeAttribute.max, label);
                    break;
                case SerializedPropertyType.Integer:
                    EditorGUI.IntSlider(position, valueProperty, (int)rangeAttribute.min, (int)rangeAttribute.max, label);
                    break;
                default:
                    EditorGUI.LabelField(position, label.text, $"Range not supported for {valueProperty.propertyType}");
                    break;
            }
        }

        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            if (attribute is not RangeAttribute rangeAttribute)
            {
                return base.CreatePropertyGUI(property);
            }

            var valueProperty = property.FindPropertyRelative("_value") ?? // vanilla property backing field
                property.FindPropertyRelative("m_InternalValue") ?? // network property backing field
                property; // vanilla property

            switch (valueProperty.propertyType)
            {
                case SerializedPropertyType.Float:
                {
                    var propertyGui = new Slider(preferredLabel, rangeAttribute.min, rangeAttribute.max);
                    propertyGui.AddToClassList(BaseField<float>.alignedFieldUssClassName);
                    propertyGui.bindingPath = valueProperty.propertyPath;
                    propertyGui.showInputField = true;
                    return propertyGui;
                }
                case SerializedPropertyType.Integer:
                {
                    var propertyGui1 = new SliderInt(preferredLabel, (int)rangeAttribute.min, (int)rangeAttribute.max);
                    propertyGui1.AddToClassList(BaseField<int>.alignedFieldUssClassName);
                    propertyGui1.bindingPath = valueProperty.propertyPath;
                    propertyGui1.showInputField = true;
                    return propertyGui1;
                }
                default:
                    return new Label($"Range not supported for {valueProperty.propertyType}");
            }
        }
    }
}

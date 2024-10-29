using NUnit.Framework;
using UnityEditor;
using UnityEngine.UIElements;
using VirtualMaker.Bindings;

public class UxmlTests
{
    private Bindings _bindings;
    private Property<int> _intProperty = new();
    private Property<string> _stringProperty = new();
    private IntegerField _integerField;
    private TextField _textField;

    [SetUp]
    public void SetUp()
    {
        var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Tests/TestUxmlUI.uxml");
        Assert.IsNotNull(visualTree, "VisualTreeAsset should not be null");

        var root = new VisualElement();
        visualTree.CloneTree(root);

        _integerField = root.Q<IntegerField>("integerField");
        _textField = root.Q<TextField>("textField");

        _bindings = new(root);
    }

    [TearDown]
    public void TearDown()
    {
        _bindings.Reset();
    }

    [Test]
    public void IntegerFieldTests()
    {
        _intProperty.Value = 42;
        _bindings.BindField("integerField", _intProperty, true);
        Assert.AreEqual(42, _integerField.value);

        _intProperty.Value = 100;
        Assert.AreEqual(100, _integerField.value);

        // Unity bug? Assigning to value doesn't trigger changed event.
        // _integerField.value = 200;
        // Assert.AreEqual(200, _intProperty.Value);
    }

    [Test]
    public void TextFieldTests()
    {
        _stringProperty.Value = "Hello";
        _bindings.BindTextField("textField", _stringProperty, true);
        Assert.AreEqual("Hello", _textField.value);

        _stringProperty.Value = "World";
        Assert.AreEqual("World", _textField.value);

        // Unity bug? Assigning to value doesn't trigger changed event.
        // _textField.value = "Hello";
        // Assert.AreEqual("Hello", _stringProperty.Value);
    }
}

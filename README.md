# com.virtualmaker.bindings

[![Discord](https://img.shields.io/discord/855294214065487932.svg?label=&logo=discord&logoColor=ffffff&color=7389D8&labelColor=6A7EC2)](https://discord.gg/xQgMW9ufN4) [![openupm](https://img.shields.io/npm/v/com.virtualmaker.bindings?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.virtualmaker.bindings/) [![openupm](https://img.shields.io/badge/dynamic/json?color=brightgreen&label=downloads&query=%24.downloads&suffix=%2Fmonth&url=https%3A%2F%2Fpackage.openupm.com%2Fdownloads%2Fpoint%2Flast-month%2Fcom.virtualmaker.bindings)](https://openupm.com/packages/com.virtualmaker.bindings/)

The VirtualMaker Bindings library provides a robust system for creating and managing properties in Unity. It allows for easy data binding between properties and UI elements, supports derived properties, and integrates seamlessly with both UGUI and UI Toolkit.

## Installation

Requires Unity 2020.3 LTS or higher.

Once submitted and approved, the recommended installation method will be though the unity package manager and [OpenUPM](https://openupm.com/packages/com.virtualmaker.bindings), but through the Unity Package Manager and Git url will suffice in the meantime.

### Via Unity Package Manager and Git url

- Open your Unity Package Manager
- Add package from git url: `https://github.com/virtual-maker-net/com.virtualmaker.bindings.git#upm`

### Via Unity Package Manager and OpenUPM

- Open your Unity project settings
- Select the `Package Manager`
![scoped-registries](Bindings/Packages/com.virtualmaker.bindings/Documentation~/images/package-manager-scopes.png)
- Add the OpenUPM package registry:
  - Name: `OpenUPM`
  - URL: `https://package.openupm.com`
  - Scope(s):
    - `com.virtualmaker`
- Open the Unity Package Manager window
- Change the Registry from Unity to `My Registries`
- Add the `Bindings` package

## Creating a `Property<T>`

To create a property, simply instantiate the `Property<T>` class with the desired type. Properties can be serialized to appear in the editor.

```cs
using VirtualMaker.Bindings;

public class ExampleComponent : MonoBehaviour
{
    [SerializeField]
    private Property<int> _intProperty = new();

    [SerializeField]
    private Property<string> _stringProperty = new();
}
```

## Binding to a Property with the `Bindings` Class

The `Bindings` class allows you to bind properties to callbacks or directly to UI elements. Here's an example of how to bind an `IntegerField` and a `TextField` to properties:

```cs
using UnityEngine.UIElements;
using VirtualMaker.Bindings;

public class Example
{
    private Bindings _bindings;
    private Property<int> _intProperty = new();
    private Property<string> _stringProperty = new();

    public void SetupBindings(VisualElement root)
    {
        _bindings = new Bindings(root);

        // Invoke a callback now and whenever the property changes
        _bindings.Bind(_stringProperty, (value) => Debug.Log(value));

        // Invoke a callback only when the property changes
        _bindings.BindDeferred(_intProperty, (value) => Debug.Log(value));

        // Two-way bind to fields in the UI
        _bindings.BindField("my-integer-field", _intProperty, true);
        _bindings.BindField("my-text-field", _stringProperty, true);
    }
}
```

## Creating a Derived Property

Derived properties allow you to create properties based on other properties. Here's an example of how to create a derived property:

```cs
using VirtualMaker.Bindings;

public class Example
{
    private Property<int> _intProperty1 = new();
    private Property<int> _intProperty2 = new();
    private Derived<int> _sumProperty;

    public Example()
    {
        _sumProperty = Derived.From(_intProperty1, _intProperty2, (val1, val2) => val1 + val2);
    }
}
```

## Using UGUI and UI Toolkit Extensions

The library provides extensions for both UGUI and UI Toolkit to facilitate binding properties to UI elements.

### UGUI Example

```cs
using UnityEngine;
using TMPro;
using VirtualMaker.Bindings;

public class UGUIExample : MonoBehaviour
{
    [SerializeField]
    private TMP_Text text;

    [SerializeField]
    private Property<string> _textProperty = new();

    private Bindings _bindings = new();

    void Start()
    {
        bindings.BindText(text, _textProperty);
    }
}
```

### UI Toolkit Example

```cs
using UnityEngine.UIElements;
using VirtualMaker.Bindings;

public class UIToolkitExample
{
    [SerializeField]
    private Property<string> _textProperty = new Property<string>();

    public void SetupBindings(VisualElement root)
    {
        var bindings = new Bindings(root);

        // Search for a text element with the name "my-label" and bind to the text property.
        bindings.BindText("my-label", _textProperty);

        // Bind to the click event of the button. You can also use On<T> to bind to any event.
        bindings.OnClick("my-button", () => Debug.Log("Button clicked!"));
    }
}
```

## Bindings at Edit Time

You can have bindings work at edit time by adding the `[ExecuteAlways]` attribute to your MonoBehaviour class, declaring your bindings in `OnEnable`, and resetting them in `OnDisable`.

### Example of Edit-Time Bindings

Here's an example of a `MonoBehaviour` with edit-time bindings:

```cs
using UnityEngine;
using UnityEngine.UIElements;
using VirtualMaker.Bindings;

[ExecuteAlways]
public class EditTimeBindingsExample : MonoBehaviour
{
    [SerializeField]
    private Property<string> _textProperty = new Property<string>();

    [SerializeField]
    private UIDocument _uiDocument;

    private Bindings _bindings;

    void OnEnable()
    {
        var root = _uiDocument_.rootVisualElement;
        _bindings = new Bindings(root);
        _bindings.BindText("my-label", _textProperty);
    }

    void OnDisable()
    {
        _bindings.Reset();
    }
}
```

Now, changing the value of `_textProperty` in the editor will automatically update the bound UI element.

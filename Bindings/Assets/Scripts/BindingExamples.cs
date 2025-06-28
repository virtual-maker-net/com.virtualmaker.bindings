using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using VirtualMaker.Bindings;
using VirtualMaker.Bindings.Extensions;

public class BindingExamples : MonoBehaviour
{
    [SerializeField]
    private Property<int> _number = new();

    [SerializeField]
    private Property<List<Color>> _colors = new();

    [SerializeField]
    private Button _button;

    [SerializeField]
    private TextMeshProUGUI _text;

    [SerializeField]
    private Transform _mouseFollower;

    [SerializeField]
    private Transform _follower2;

    private void OnEnable()
    {
        // General binding
        this.Bind(_number, x => Debug.Log(x));

        // Binding a property (auto-generated function)
        _text.BindText(_number);

        // Binding a derived property (auto-generated function)
        var color = Derived.From(_number, _colors, (n, c) => c[n % c.Count]);
        _text.BindColor(color);

        // Binding a UnityEvent with lifetime context
        _button.onClick.Bind(this, () => _number.Value += 1);

        // Bind to a non-property (runs on update) (auto-generated function)
        _mouseFollower.BindPosition(() => Input.mousePosition);

        // Bind to do something every X seconds
        this.BindUpdate(1.0f, () => _number.Value += 1);

        // Shorthand for:
        // _follower2.BindPosition(() => Vector3.Lerp(_follower2.position, _mouseFollower.position, 10f * Time.smoothDeltaTime));
        _follower2.BindLerpPosition(10f, () => _mouseFollower.position);
    }

    private void OnDisable()
    {
        this.ResetBindings();
        _text.ResetBindings();
        _mouseFollower.ResetBindings();
    }
}
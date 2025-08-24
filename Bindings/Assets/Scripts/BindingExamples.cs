using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VirtualMaker.Bindings;
using VirtualMaker.Bindings.Extensions;

public class BindingExamples : BindingMonoBehaviour
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

    [SerializeField]
    private Transform _animated;

    [SerializeField]
    private Hoverable _hoverImage;

    protected override void Bind()
    {
        // General binding
        Bindings.Bind(_number, x => Debug.Log(x));

        // Binding a property (auto-generated function)
        _text.BindText(_number);

        // Binding a derived property (auto-generated function)
        var color = Derived.From(_number, _colors, (n, c) => c[n % c.Count]);
        _text.BindColor(color);

        // Binding a UnityEvent with lifetime context
        _button.onClick.Bind(() => _number.Value += 1);

        // Bind to a non-property (runs on update) (auto-generated function)
        _mouseFollower.BindPosition(() => Input.mousePosition);

        // Bind to do something every X seconds
        Bindings.BindInterval(1.0f, () => _number.Value += 1);

        // Bind continuous lerp - shorthand for:
        // _follower2.BindPosition(() => Vector3.Lerp(_follower2.position, _mouseFollower.position, 10f * Time.smoothDeltaTime));
        _follower2.BindPositionLerp(10f, () => _mouseFollower.position);

        // Animate between two points with a time curve
        // Shorthand for:
        // _animated.Animate(Easing.EaseInOut(5), t => _animated.transform.localPosition = Vector3.Lerp(new Vector3(-200, 0, 0), new Vector3(200, 0, 0), t));
        _animated.AnimateLocalPosition(new Vector3(-200, 0, 0), new Vector3(200, 0, 0), Easing.EaseInOut(5));

        // Transition colors on hover
        var transition = Bindings.CreateTransition(_hoverImage.Hovering, Easing.EaseOut(0.2f));
        _hoverImage.GetComponent<Image>().BindColor(transition, v => new Color(1, v, 1));
    }
}
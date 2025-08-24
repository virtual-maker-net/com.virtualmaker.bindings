using UnityEngine;
using UnityEngine.EventSystems;
using VirtualMaker.Bindings;

public class Hoverable : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Property<bool> _hovering = new Property<bool>();
    public IProperty<bool> Hovering => _hovering;

    public void OnPointerEnter(PointerEventData eventData)
    {
        _hovering.Value = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _hovering.Value = false;
    }
}
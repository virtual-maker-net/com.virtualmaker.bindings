#if UNITY_UGUI

using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace VirtualMaker.Bindings
{
    public partial class Bindings
    {
        private void OnEventTrigger(EventTrigger evtTrigger, EventTriggerType evtType, UnityAction action)
            => OnEventTrigger(evtTrigger, evtType, (BaseEventData evtData) => action());

        private void OnEventTrigger<T>(EventTrigger evtTrigger, EventTriggerType evtType, UnityAction<T> action) where T : BaseEventData
        {
            var entry = new EventTrigger.Entry()
            {
                eventID = evtType
            };
            evtTrigger.triggers.Add(entry);

            On(entry.callback, data => action((T)data));
            AddUnsubscriber(() => evtTrigger.triggers.Remove(entry));
        }

        public void OnBeginDrag(EventTrigger evtTrigger, UnityAction action)
            => OnEventTrigger(evtTrigger, EventTriggerType.BeginDrag, action);

        public void OnBeginDrag(EventTrigger evtTrigger, UnityAction<PointerEventData> action)
            => OnEventTrigger(evtTrigger, EventTriggerType.BeginDrag, action);

        public void OnCancel(EventTrigger evtTrigger, UnityAction action)
            => OnEventTrigger(evtTrigger, EventTriggerType.Cancel, action);

        public void OnCancel(EventTrigger evtTrigger, UnityAction<BaseEventData> action)
            => OnEventTrigger(evtTrigger, EventTriggerType.Cancel, action);

        public void OnDeselect(EventTrigger evtTrigger, UnityAction action)
            => OnEventTrigger(evtTrigger, EventTriggerType.Deselect, action);

        public void OnDeselect(EventTrigger evtTrigger, UnityAction<BaseEventData> action)
            => OnEventTrigger(evtTrigger, EventTriggerType.Deselect, action);

        public void OnDrag(EventTrigger evtTrigger, UnityAction action)
            => OnEventTrigger(evtTrigger, EventTriggerType.Drag, action);

        public void OnDrag(EventTrigger evtTrigger, UnityAction<PointerEventData> action)
            => OnEventTrigger(evtTrigger, EventTriggerType.Drag, action);

        public void OnDrop(EventTrigger evtTrigger, UnityAction action)
            => OnEventTrigger(evtTrigger, EventTriggerType.Drop, action);

        public void OnDrop(EventTrigger evtTrigger, UnityAction<PointerEventData> action)
            => OnEventTrigger(evtTrigger, EventTriggerType.Drop, action);

        public void OnEndDrag(EventTrigger evtTrigger, UnityAction action)
            => OnEventTrigger(evtTrigger, EventTriggerType.EndDrag, action);

        public void OnEndDrag(EventTrigger evtTrigger, UnityAction<PointerEventData> action)
            => OnEventTrigger(evtTrigger, EventTriggerType.EndDrag, action);

        public void OnIntializePotentialDrag(EventTrigger evtTrigger, UnityAction action)
            => OnEventTrigger(evtTrigger, EventTriggerType.InitializePotentialDrag, action);

        public void OnIntializePotentialDrag(EventTrigger evtTrigger, UnityAction<PointerEventData> action)
            => OnEventTrigger(evtTrigger, EventTriggerType.InitializePotentialDrag, action);

        public void OnMove(EventTrigger evtTrigger, UnityAction action)
            => OnEventTrigger(evtTrigger, EventTriggerType.Move, action);

        public void OnMove(EventTrigger evtTrigger, UnityAction<AxisEventData> action)
            => OnEventTrigger(evtTrigger, EventTriggerType.Move, action);

        public void OnPointerClick(EventTrigger evtTrigger, UnityAction action)
            => OnEventTrigger(evtTrigger, EventTriggerType.PointerClick, action);

        public void OnPointerClick(EventTrigger evtTrigger, UnityAction<PointerEventData> action)
            => OnEventTrigger(evtTrigger, EventTriggerType.PointerClick, action);

        public void OnPointerDown(EventTrigger evtTrigger, UnityAction action)
            => OnEventTrigger(evtTrigger, EventTriggerType.PointerDown, action);

        public void OnPointerDown(EventTrigger evtTrigger, UnityAction<PointerEventData> action)
            => OnEventTrigger(evtTrigger, EventTriggerType.PointerDown, action);

        public void OnPointerEnter(EventTrigger evtTrigger, UnityAction action)
            => OnEventTrigger(evtTrigger, EventTriggerType.PointerEnter, action);

        public void OnPointerEnter(EventTrigger evtTrigger, UnityAction<PointerEventData> action)
            => OnEventTrigger(evtTrigger, EventTriggerType.PointerEnter, action);

        public void OnPointerExit(EventTrigger evtTrigger, UnityAction action)
            => OnEventTrigger(evtTrigger, EventTriggerType.PointerExit, action);

        public void OnPointerExit(EventTrigger evtTrigger, UnityAction<PointerEventData> action)
            => OnEventTrigger(evtTrigger, EventTriggerType.PointerExit, action);

        public void OnPointerUp(EventTrigger evtTrigger, UnityAction action)
            => OnEventTrigger(evtTrigger, EventTriggerType.PointerUp, action);

        public void OnPointerUp(EventTrigger evtTrigger, UnityAction<PointerEventData> action)
            => OnEventTrigger(evtTrigger, EventTriggerType.PointerUp, action);

        public void OnScroll(EventTrigger evtTrigger, UnityAction action)
            => OnEventTrigger(evtTrigger, EventTriggerType.Scroll, action);

        public void OnScroll(EventTrigger evtTrigger, UnityAction<PointerEventData> action)
            => OnEventTrigger(evtTrigger, EventTriggerType.Scroll, action);

        public void OnSelect(EventTrigger evtTrigger, UnityAction action)
            => OnEventTrigger(evtTrigger, EventTriggerType.Select, action);

        public void OnSelect(EventTrigger evtTrigger, UnityAction<BaseEventData> action)
            => OnEventTrigger(evtTrigger, EventTriggerType.Select, action);

        public void OnSubmit(EventTrigger evtTrigger, UnityAction action)
            => OnEventTrigger(evtTrigger, EventTriggerType.Submit, action);

        public void OnSubmit(EventTrigger evtTrigger, UnityAction<BaseEventData> action)
            => OnEventTrigger(evtTrigger, EventTriggerType.Submit, action);

        public void OnUpdateSelected(EventTrigger evtTrigger, UnityAction action)
            => OnEventTrigger(evtTrigger, EventTriggerType.UpdateSelected, action);

        public void OnUpdateSelected(EventTrigger evtTrigger, UnityAction<BaseEventData> action)
            => OnEventTrigger(evtTrigger, EventTriggerType.UpdateSelected, action);
    }
}

#endif // UNITY_UGUI
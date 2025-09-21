#if UNITY_UGUI

using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace VirtualMaker.Bindings
{
    public static partial class Bindings
    {
        private static void BindEventTrigger(BindingContext context, EventTrigger evtTrigger, EventTriggerType evtType, UnityAction action)
            => BindEventTrigger(evtTrigger, evtType, (BaseEventData evtData) => action());

        private static void BindEventTrigger<T>(BindingContext context, EventTrigger evtTrigger, EventTriggerType evtType, UnityAction<T> action) where T : BaseEventData
        {
            var entry = new EventTrigger.Entry()
            {
                eventID = evtType
            };

            BindingsInternal.BindUity(context, evtTrigger.triggers.Add, evtTrigger.triggers.Remove, action);
        }

        public static void BindEventBeginDrag(EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.BeginDrag, action);

        public static void BindEventBeginDrag(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.BeginDrag, action);

        public static void BindEventBeginDrag(EventTrigger evtTrigger, UnityAction<PointerEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.BeginDrag, action);

        public static void BindEventBeginDrag(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction<PointerEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.BeginDrag, action);

        public static void BindEventCancel(EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.Cancel, action);

        public static void BindEventCancel(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.Cancel, action);

        public static void BindEventCancel(EventTrigger evtTrigger, UnityAction<BaseEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.Cancel, action);

        public static void BindEventCancel(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction<BaseEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.Cancel, action);

        public static void BindEventDeselect(EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.Deselect, action);

        public static void BindEventDeselect(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.Deselect, action);

        public static void BindEventDeselect(EventTrigger evtTrigger, UnityAction<BaseEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.Deselect, action);

        public static void BindEventDeselect(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction<BaseEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.Deselect, action);

        public static void BindEventDrag(EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.Drag, action);

        public static void BindEventDrag(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.Drag, action);

        public static void BindEventDrag(EventTrigger evtTrigger, UnityAction<PointerEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.Drag, action);

        public static void BindEventDrag(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction<PointerEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.Drag, action);

        public static void BindEventDrop(EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.Drop, action);

        public static void BindEventDrop(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.Drop, action);

        public static void BindEventDrop(EventTrigger evtTrigger, UnityAction<PointerEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.Drop, action);

        public static void BindEventDrop(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction<PointerEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.Drop, action);

        public static void BindEventEndDrag(EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.EndDrag, action);

        public static void BindEventEndDrag(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.EndDrag, action);

        public static void BindEventEndDrag(EventTrigger evtTrigger, UnityAction<PointerEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.EndDrag, action);

        public static void BindEventEndDrag(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction<PointerEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.EndDrag, action);

        public static void BindEventIntializePotentialDrag(EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.InitializePotentialDrag, action);

        public static void BindEventIntializePotentialDrag(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.InitializePotentialDrag, action);

        public static void BindEventIntializePotentialDrag(EventTrigger evtTrigger, UnityAction<PointerEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.InitializePotentialDrag, action);

        public static void BindEventIntializePotentialDrag(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction<PointerEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.InitializePotentialDrag, action);

        public static void BindEventMove(EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.Move, action);

        public static void BindEventMove(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.Move, action);

        public static void BindEventMove(EventTrigger evtTrigger, UnityAction<AxisEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.Move, action);

        public static void BindEventMove(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction<AxisEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.Move, action);

        public static void BindEventPointerClick(EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.PointerClick, action);

        public static void BindEventPointerClick(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.PointerClick, action);

        public static void BindEventPointerClick(EventTrigger evtTrigger, UnityAction<PointerEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.PointerClick, action);

        public static void BindEventPointerClick(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction<PointerEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.PointerClick, action);

        public static void BindEventPointerDown(EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.PointerDown, action);

        public static void BindEventPointerDown(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.PointerDown, action);

        public static void BindEventPointerDown(EventTrigger evtTrigger, UnityAction<PointerEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.PointerDown, action);

        public static void BindEventPointerDown(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction<PointerEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.PointerDown, action);

        public static void BindEventPointerEnter(EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.PointerEnter, action);

        public static void BindEventPointerEnter(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.PointerEnter, action);

        public static void BindEventPointerEnter(EventTrigger evtTrigger, UnityAction<PointerEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.PointerEnter, action);

        public static void BindEventPointerEnter(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction<PointerEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.PointerEnter, action);

        public static void BindEventPointerExit(EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.PointerExit, action);

        public static void BindEventPointerExit(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.PointerExit, action);

        public static void BindEventPointerExit(EventTrigger evtTrigger, UnityAction<PointerEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.PointerExit, action);

        public static void BindEventPointerExit(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction<PointerEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.PointerExit, action);

        public static void BindEventPointerUp(EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.PointerUp, action);

        public static void BindEventPointerUp(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.PointerUp, action);

        public static void BindEventPointerUp(EventTrigger evtTrigger, UnityAction<PointerEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.PointerUp, action);

        public static void BindEventPointerUp(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction<PointerEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.PointerUp, action);

        public static void BindEventScroll(EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.Scroll, action);

        public static void BindEventScroll(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.Scroll, action);

        public static void BindEventScroll(EventTrigger evtTrigger, UnityAction<PointerEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.Scroll, action);

        public static void BindEventScroll(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction<PointerEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.Scroll, action);

        public static void BindEventSelect(EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.Select, action);

        public static void BindEventSelect(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.Select, action);

        public static void BindEventSelect(EventTrigger evtTrigger, UnityAction<BaseEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.Select, action);

        public static void BindEventSelect(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction<BaseEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.Select, action);

        public static void BindEventSubmit(EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.Submit, action);

        public static void BindEventSubmit(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.Submit, action);

        public static void BindEventSubmit(EventTrigger evtTrigger, UnityAction<BaseEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.Submit, action);

        public static void BindEventSubmit(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction<BaseEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.Submit, action);

        public static void BindEventUpdateSelected(EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.UpdateSelected, action);

        public static void BindEventUpdateSelected(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.UpdateSelected, action);

        public static void BindEventUpdateSelected(EventTrigger evtTrigger, UnityAction<BaseEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(cancellationToken), evtTrigger, EventTriggerType.UpdateSelected, action);

        public static void BindEventUpdateSelected(this UnityEngine.Object obj, EventTrigger evtTrigger, UnityAction<BaseEventData> action, CancellationToken cancellationToken = default)
            => BindEventTrigger(new(obj, cancellationToken), evtTrigger, EventTriggerType.UpdateSelected, action);
    }
}

#endif // UNITY_UGUI
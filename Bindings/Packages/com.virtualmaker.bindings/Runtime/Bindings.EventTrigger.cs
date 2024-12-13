using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace VirtualMaker.Bindings
{
    public partial class Bindings
    {
        public void On(EventTrigger evtTrigger, EventTriggerType evtType, UnityAction action)
            => On(evtTrigger, evtType, _ => action());

        public void On(EventTrigger evtTrigger, EventTriggerType evtType, UnityAction<BaseEventData> action)
        {
            var entry = new EventTrigger.Entry()
            {
                eventID = evtType
            };
            evtTrigger.triggers.Add(entry);

            On(entry.callback, action);
            AddUnsubscriber(() => evtTrigger.triggers.Remove(entry));
        }

        public void On<T>(EventTrigger evtTrigger, EventTriggerType evtType, UnityAction<T> action) where T : BaseEventData
        {
            var entry = new EventTrigger.Entry()
            {
                eventID = evtType
            };
            evtTrigger.triggers.Add(entry);

            On(entry.callback, data => action((T)data));
            AddUnsubscriber(() => evtTrigger.triggers.Remove(entry));
        }
    }
}
using System;

namespace VirtualMaker.Bindings.Reflection
{
    public static class BindingsOnExtension
    {
        public static void OnEventMember<TDelegate>(this Bindings bindings, object cls, string eventName, TDelegate action) where TDelegate : Delegate
        {
            var objType = cls.GetType();
            if (!objType.IsClass)
            {
                throw new($"Object type \"{objType}\" is not a class.");
            }

            var evtInfo = objType.GetEvent(eventName);
            if (evtInfo == null)
            {
                throw new($"Event \"{eventName}\" not found in {cls.GetType()}");
            }

            var addInfo = evtInfo.GetAddMethod();
            if (addInfo == null)
            {
                throw new($"No add method found for event \"{eventName}\"");
            }

            var removeInfo = evtInfo.GetRemoveMethod();
            if (removeInfo == null)
            {
                throw new($"No remove method found for event \"{eventName}\"");
            }

            var eventDelegateType = evtInfo.EventHandlerType;
            if (action.GetType() != eventDelegateType)
            {
                throw new($"Event \"{eventName}\" was expecting a type \"{eventDelegateType}\" but instead got \"{action.GetType()}\"");
            }

            var args = new object[] { action };
            addInfo.Invoke(cls, args);

            bindings.AddUnsubscriber(() => removeInfo.Invoke(cls, args));
        }
    }
}
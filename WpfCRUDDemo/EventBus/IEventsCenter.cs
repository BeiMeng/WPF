using System;

namespace WpfCRUDDemo.EventBus
{
    public interface IEventsCenter
    {
        void RegisterEvent(string key, Action<object> @event);
        void TriggerEvent(string key,object param);
    }
}
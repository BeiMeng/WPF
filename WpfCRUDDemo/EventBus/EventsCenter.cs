using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace WpfCRUDDemo.EventBus
{
    public class EventsCenter:IEventsCenter
    {
        private static EventsCenter instance;
        private EventsCenter()
        {
        }
        public static EventsCenter Instance
        {
            get
            {
                return Nested.Instance;
            }
        }
        class Nested
        {
            static Nested(){}
            internal static readonly EventsCenter Instance = new EventsCenter();
        }
        //public Dictionary<string, Action<object>> EventsDic { get; private set; }
        private static readonly ConcurrentDictionary<string, Action<object>> EventsDic=new ConcurrentDictionary<string, Action<object>>();
        public void RegisterEvent(string key, Action<object> @event)
        {
            EventsDic.TryAdd(key,@event);
        }
        public void TriggerEvent(string key, object param)
        {
            //判断是否存在相应的key并显示
            if (EventsDic.ContainsKey(key))
            {
                var action = EventsDic[key];
                action(param);
            }
        }
    }
}
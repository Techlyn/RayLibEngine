using System;
using System.Collections.Generic;
using System.Text;

namespace RayLibEngine.Core
{
    public static class EventManager
    {
        private static readonly HashSet<string> AllowedEvents = new()
        {
            KeyboardEvent.KEYBOARD_EVENT,
            MouseEvent.MSE_EVENT,
            EventStep.STEP_EVENT,

        };


        public static void RegisterInterest(GameObject obj, string event_type)
        {
            if (AllowedEvents.Contains(event_type))
            {
                EventHandler.RegisterInterest(obj, event_type);
            }
            else
            {
                Logger.WriteLog(LogLevel.LOG_WARNING, $"Event '{event_type}' not whitelisted and was ignored.");
            }
        }

        public static void WhitelistEvent(string event_type)
        {
            AllowedEvents.Add(event_type);
            Logger.WriteLog(LogLevel.LOG_INFO, $"New Event '{event_type}' has been whitelisted.");
        }
        public static void RemoveEvent(string event_type)
        {
            AllowedEvents.Remove(event_type);
            Logger.WriteLog(LogLevel.LOG_INFO, $"Event '{event_type} has been remove from whitelist.");
        }
        public static List<String> ListEvents()
        {
            List<String> list = new List<String>();
            foreach (string event_type in AllowedEvents)
            {
                list.Add(event_type);
            }
            return list;
        }
    }
}

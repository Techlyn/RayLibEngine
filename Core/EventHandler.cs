using System;
using System.Collections.Generic;
using System.Text;

namespace RayLibEngine.Core
{
    public static class EventHandler
    {
        private static int _event_count;

        private static Dictionary<String, List<GameObject>> _ObjectDictionary = new Dictionary<String, List<GameObject>>();

         

        public static int OnEvent(Event _event)
        { 
            if (_ObjectDictionary.ContainsKey(_event.Type))
            {
                foreach (GameObject obj in _ObjectDictionary[_event.Type])
                {
                    if (obj.Active)
                    {
                        obj.ObjectEvent(_event); // not sure if I'll name this called object method eventHandler, as this class is called EventHandler.
                        // who knew naming would be so hard.
                        return 0;
                    }
                }
            }
            return 1;
        }


        public static void RegisterInterest(GameObject obj, string event_type)
        {
            if (_ObjectDictionary.ContainsKey(event_type))
            {
                _ObjectDictionary[event_type].Add(obj);
                return;
            }

            _ObjectDictionary.Add(event_type, new List<GameObject>());
            _ObjectDictionary[event_type].Add(obj);
            return;
        }

        public static void UnregisterInterest(GameObject obj, string event_type)
        {
            if(_ObjectDictionary.ContainsKey(event_type))
            {
                _ObjectDictionary[event_type].Remove(obj);
            }
        }


        
    }
}

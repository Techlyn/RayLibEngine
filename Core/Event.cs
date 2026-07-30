using System;
using System.Collections.Generic;
using System.Text;

namespace RayLibEngine.Core
{
    public class Event
    {
        public const string UNDEFINED_EVENT = "UNDEFINED";

        private string _eventType = UNDEFINED_EVENT;

        public string Type { get { return _eventType; } set { _eventType = value; } }


    }
}

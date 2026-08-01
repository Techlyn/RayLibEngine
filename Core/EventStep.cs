using System;
using System.Collections.Generic;
using System.Text;

namespace RayLibEngine.Core
{
    internal class EventStep : Event
    {
        public const string STEP_EVENT = "step_event";

        private long _stepCount = 0;


        public EventStep()
        {
            Type = STEP_EVENT;
        }

        public long StepCount { get { return _stepCount; } set { _stepCount = value; } }
    }
}

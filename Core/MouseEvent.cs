using System;
using System.Collections.Generic;
using System.Text;

namespace RayLibEngine.Core
{
    
    public enum EventMouseAction
    {
        UNDEFINED_MOUSE_ACTION,
        CLICKED,
        MOVED,
    }
    namespace Mouse
    {
        public enum Button
        {
            UNDEFINED_MOUSE_BUTTON,
            LEFT,
            RIGHT,
            MIDDLE,
        }
    }
    public class MouseEvent : Event
    {
        public const string MSE_EVENT = "mouse_event";

        private EventMouseAction _mouse_action = EventMouseAction.UNDEFINED_MOUSE_ACTION;
        private Mouse.Button _mouse_button = Mouse.Button.UNDEFINED_MOUSE_BUTTON;
        private Vector _mouse_v = new Vector();

        public MouseEvent()
        {
            Type = MSE_EVENT;
        }

        public EventMouseAction MouseAction { get { return _mouse_action; } set { _mouse_action = value; } }
        public Mouse.Button MouseButton { get { return _mouse_button; } set { _mouse_button = value; } }
        public Vector MouseVector { get { return _mouse_v;  } set { _mouse_v = value; } }
    }
}

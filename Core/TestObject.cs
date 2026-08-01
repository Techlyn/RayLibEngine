using System;
using System.Collections.Generic;
using System.Text;
using static RayLibEngine.Core.EventKeyboardAction;


namespace RayLibEngine.Core
{
    public class TestObject : GameObject
    {

        public TestObject()
        {
            Type = "Test";
            EventManager.RegisterInterest(this, KeyboardEvent.KEYBOARD_EVENT);
        }

        public override void ObjectEvent(Event _event)
        {
            if (_event.Type == KeyboardEvent.KEYBOARD_EVENT)
            {
                KeyboardEvent keyboard_event = (KeyboardEvent)_event;
                kbd(keyboard_event);
                return;
            }

        }

        private void kbd(KeyboardEvent keyboard_event)
        {

            if (keyboard_event.KeyboardAction == KEY_PRESSED)
            {
                Console.WriteLine($"Keyboard Key '{keyboard_event.KeyValue}' Was Pressed.");
            }
           

        }
    }
}

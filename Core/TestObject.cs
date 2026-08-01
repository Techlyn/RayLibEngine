using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using static RayLibEngine.Core.EventKeyboardAction;


namespace RayLibEngine.Core
{
    public class TestObject : GameObject
    {

        private int move_slowdown = 0;
        private int move_countdown;
        private Vector deltaMove = new Vector();
        private SimpleBox box;
        
        


        public TestObject()
        {
            Type = "Test";
            EventManager.RegisterInterest(this, KeyboardEvent.KEYBOARD_EVENT);
            EventManager.RegisterInterest(this, EventStep.STEP_EVENT);

            move_countdown = move_slowdown;
            Position = new Vector(300, 200);
           
            
        }

        public override void ObjectEvent(Event _event)
        {
            if (_event.Type == KeyboardEvent.KEYBOARD_EVENT)
            {
                KeyboardEvent keyboard_event = (KeyboardEvent)_event;
                kbd(keyboard_event);
                return;
            }

            if (_event.Type == EventStep.STEP_EVENT)
            {
                Step();
                return;
            }

        }

        private void kbd(KeyboardEvent keyboard_event)
        {
            if (keyboard_event.KeyValue == Keyboard.Key.W)
            {
                if (keyboard_event.KeyboardAction == KEY_PRESSED) deltaMove.y -= 1;
                if (keyboard_event.KeyboardAction == KEY_RELEASED) deltaMove.y += 1;
            }
            if (keyboard_event.KeyValue == Keyboard.Key.S)
            {
                if (keyboard_event.KeyboardAction == KEY_PRESSED) deltaMove.y += 1;
                if (keyboard_event.KeyboardAction == KEY_RELEASED) deltaMove.y -= 1;
            }
            if (keyboard_event.KeyValue == Keyboard.Key.A)
            {
                if (keyboard_event.KeyboardAction == KEY_PRESSED) deltaMove.x -= 1;
                if (keyboard_event.KeyboardAction == KEY_RELEASED) deltaMove.x += 1;
            }
            if (keyboard_event.KeyValue == Keyboard.Key.D)
            {
                if (keyboard_event.KeyboardAction == KEY_PRESSED) deltaMove.x += 1;
                if (keyboard_event.KeyboardAction == KEY_RELEASED) deltaMove.x -= 1;
            }
        }

        private void Step()
        {
            move_countdown--;
            if (move_countdown < 0) move_countdown = 0;


            if (deltaMove.x == 0 || deltaMove.y == 0) Move(deltaMove);

        }

        private void Move(Vector delta_move)
        {
            if (move_countdown > 0) return;
            move_countdown = move_slowdown;

            Vector new_pos = Position + delta_move;
            WorldGenerator.MoveObject(this, new_pos);
        }

        public override void Draw()
        {
            box = new SimpleBox(Position);
        }
    }
}

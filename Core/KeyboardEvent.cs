using System;
using System.Collections.Generic;
using System.Text;

namespace RayLibEngine.Core
{
    public enum EventKeyboardAction
    {
        UNDEFINED_KEYBOARD_ACTION,
        KEY_PRESSED,
        KEY_RELEASED,
    }

    namespace Keyboard
    {
       public enum Key
        {
            UNDEFINED_KEY,
            SPACE, RETURN, BACKSPACE, ESCAPE, TAB, LEFTARROW, RIGHTARROW, UPARROW, DOWNARROW,
            PAUSE, MINUS, PLUS, GRAVE, PERIOD, COMMA, SLASH, LCONTROL, RCONTROL,
            LSHIFT, RSHIFT, LALT, RALT, F1, F2, F3, F4, F5, F6, F7, F8, F9, F10, F11, F12,
            A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W,
            X, Y, Z, ONE, TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, ZERO, NUM1, NUM2, NUM3, NUM4, NUM5, NUM6, NUM7, NUM8, NUM9, NUM0
        };
    }
    public class KeyboardEvent : Event
    {
        public const string KEYBOARD_EVENT = "keyboard_event";

        private Keyboard.Key _key_val = Keyboard.Key.UNDEFINED_KEY;
        private EventKeyboardAction _keyboard_action = EventKeyboardAction.UNDEFINED_KEYBOARD_ACTION;

        public KeyboardEvent()
        {
            Type = KEYBOARD_EVENT;
        }

        public Keyboard.Key KeyValue { get { return _key_val; } set { _key_val = value; } } 
        public EventKeyboardAction KeyboardAction { get { return _keyboard_action; } set { _keyboard_action = value; } }

    }
}

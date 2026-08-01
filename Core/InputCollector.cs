using Raylib_cs;

namespace RayLibEngine.Core;

public static class InputCollector
{
    private static bool[] previousKeyState = new bool[512];

    public static void KeyboardInput()
    {


        int key = Raylib.GetKeyPressed();
        while (key != 0)
        {
            Keyboard.Key engine_key = GetEngineKey((KeyboardKey)key);
            KeyboardEvent k_event = new KeyboardEvent();
            k_event.KeyValue = engine_key;
            k_event.KeyboardAction = EventKeyboardAction.KEY_PRESSED;
            EventHandler.OnEvent(k_event);
            

            key = Raylib.GetKeyPressed();
        }

        for (int i = 0; i < 512; i++)
        {
            bool isDownNow = Raylib.IsKeyDown((KeyboardKey)i);
            if (!isDownNow && previousKeyState[i])
            {
                Keyboard.Key engine_key = GetEngineKey((KeyboardKey)i);
                KeyboardEvent k_event = new KeyboardEvent();
                k_event.KeyValue = engine_key;
                k_event.KeyboardAction = EventKeyboardAction.KEY_RELEASED;
                EventHandler.OnEvent(k_event);
            }
            previousKeyState[i] = isDownNow;
        }

    }

    public static void MouseInput()
    {
        Vector MoveInput = new Vector();


    }


    public static Keyboard.Key GetEngineKey(KeyboardKey key)
    {
        switch (key)
        {
            case KeyboardKey.Space:
                return Keyboard.Key.SPACE;
            case KeyboardKey.Enter:
                return Keyboard.Key.RETURN;
            case KeyboardKey.Backspace:
                return Keyboard.Key.BACKSPACE;
            case KeyboardKey.Escape:
                return Keyboard.Key.ESCAPE;
            case KeyboardKey.Tab:
                return Keyboard.Key.TAB;
            case KeyboardKey.Left:
                return Keyboard.Key.LEFTARROW;
            case KeyboardKey.Right:
                return Keyboard.Key.RIGHTARROW;
            case KeyboardKey.Up:
                return Keyboard.Key.UPARROW;
            case KeyboardKey.Down:
                return Keyboard.Key.DOWNARROW;
            case KeyboardKey.Pause:
                return Keyboard.Key.PAUSE;
            case KeyboardKey.Minus:
                return Keyboard.Key.MINUS;
            case KeyboardKey.KpAdd:
                return Keyboard.Key.PLUS;
            case KeyboardKey.Grave:
                return Keyboard.Key.GRAVE;
            case KeyboardKey.Period:
                return Keyboard.Key.PERIOD;
            case KeyboardKey.Comma:
                return Keyboard.Key.COMMA;
            case KeyboardKey.Slash:
                return Keyboard.Key.SLASH;
            case KeyboardKey.LeftControl:
                return Keyboard.Key.LCONTROL;
            case KeyboardKey.RightControl:
                return Keyboard.Key.RCONTROL;
            case KeyboardKey.LeftShift:
                return Keyboard.Key.LSHIFT;
            case KeyboardKey.RightShift:
                return Keyboard.Key.RSHIFT;
            case KeyboardKey.F1:
                return Keyboard.Key.F1;
            case KeyboardKey.F2:
                return Keyboard.Key.F2;
            case KeyboardKey.F3:
                return Keyboard.Key.F3;
            case KeyboardKey.F4:
                return Keyboard.Key.F4;
            case KeyboardKey.F5:
                return Keyboard.Key.F5;
            case KeyboardKey.F6:
                return Keyboard.Key.F6;
            case KeyboardKey.F7:
                return Keyboard.Key.F7;
            case KeyboardKey.F8:
                return Keyboard.Key.F8;
            case KeyboardKey.F9:
                return Keyboard.Key.F9;
            case KeyboardKey.F10:
                return Keyboard.Key.F10;
            case KeyboardKey.F11:
                return Keyboard.Key.F11;
            case KeyboardKey.F12:
                return Keyboard.Key.F12;
            case KeyboardKey.A:
                return Keyboard.Key.A;
            case KeyboardKey.B:
                return Keyboard.Key.B;
            case KeyboardKey.C:
                return Keyboard.Key.C;
            case KeyboardKey.D:
                return Keyboard.Key.D;
            case KeyboardKey.E:
                return Keyboard.Key.E;
            case KeyboardKey.F:
                return Keyboard.Key.F;
            case KeyboardKey.G:
                return Keyboard.Key.G;
            case KeyboardKey.H:
                return Keyboard.Key.H;
            case KeyboardKey.I:
                return Keyboard.Key.I;
            case KeyboardKey.J:
                return Keyboard.Key.J;
            case KeyboardKey.K:
                return Keyboard.Key.K;
            case KeyboardKey.L:
                return Keyboard.Key.L;
            case KeyboardKey.M:
                return Keyboard.Key.M;
            case KeyboardKey.N:
                return Keyboard.Key.N;
            case KeyboardKey.O:
                return Keyboard.Key.O;
            case KeyboardKey.P:
                return Keyboard.Key.P;
            case KeyboardKey.Q:
                return Keyboard.Key.Q;
            case KeyboardKey.R:
                return Keyboard.Key.R;
            case KeyboardKey.S:
                return Keyboard.Key.S;
            case KeyboardKey.T:
                return Keyboard.Key.T;
            case KeyboardKey.U:
                return Keyboard.Key.U;
            case KeyboardKey.V:
                return Keyboard.Key.V;
            case KeyboardKey.W:
                return Keyboard.Key.W;
            case KeyboardKey.X:
                return Keyboard.Key.X;
            case KeyboardKey.Y:
                return Keyboard.Key.Y;
            case KeyboardKey.Z:
                return Keyboard.Key.Z;
            case KeyboardKey.One:
                return Keyboard.Key.ONE;
            case KeyboardKey.Two:
                return Keyboard.Key.TWO;
            case KeyboardKey.Three:
                return Keyboard.Key.THREE;
            case KeyboardKey.Four:
                return Keyboard.Key.FOUR;
            case KeyboardKey.Five:
                return Keyboard.Key.FIVE;
            case KeyboardKey.Six:
                return Keyboard.Key.SIX;
            case KeyboardKey.Seven:
                return Keyboard.Key.SEVEN;
            case KeyboardKey.Eight:
                return Keyboard.Key.EIGHT;
            case Keyboard.Key.Nine:
                return Keyboard.Key.NINE;
            case KeyboardKey.Zero:
                return Keyboard.Key.ZERO;
            case KeyboardKey.Kp1:
                return Keyboard.Key.NUM1;
            case KeyboardKey.Kp2:
                return Keyboard.Key.NUM2;
            case KeyboardKey.Kp3:
                return Keyboard.Key.NUM3;
            case KeyboardKey.Kp4:
                return Keyboard.Key.NUM4;
            case KeyboardKey.Kp5:
                return Keyboard.Key.NUM5;
            case KeyboardKey.Kp6:
                return Keyboard.Key.NUM6;
            case KeyboardKey.Kp7:
                return Keyboard.Key.NUM7;
            case KeyboardKey.Kp8:
                return Keyboard.Key.NUM8;
            case KeyboardKey.Kp9:
                return Keyboard.Key.NUM9;
            case KeyboardKey.Kp0:
                return Keyboard.Key.NUM0;
            default:
                Logger.WriteLog(LogLevel.LOG_WARNING, "Error! Undefined key pressed key code is: {key}, refer to Raylib.KeyboardKey");
                break;
        }
        return Keyboard.Key.UNDEFINED_KEY;

    }
}

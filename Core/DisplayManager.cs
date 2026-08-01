using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using Raylib_cs;

namespace RayLibEngine.Core
{
    public class DisplayManager
    {
        public const int WINDOW_HORIZONTAL_PIXELS_DEFAULT = 1024;
        public const int WINDOW_VERTICAL_PIXELS_DEFAULT = 768;
        public const string WINDOW_TITLE_DEFAULT = "Game";
        public static Raylib_cs.Color DEFAULT_BACKGROUND_COLOR = Raylib_cs.Color.Black;


        private static int _windowHozPixel = WINDOW_HORIZONTAL_PIXELS_DEFAULT;
        private static int _windowVertPixel = WINDOW_VERTICAL_PIXELS_DEFAULT;
        private static Color _backgroundColor = DEFAULT_BACKGROUND_COLOR;
        private static string _windowTitle = WINDOW_TITLE_DEFAULT;

        public static void StartUp()
        {
            Raylib.InitWindow(_windowHozPixel, _windowVertPixel, WindowTitle);
            
        }

       public static void ShutDown()
        {
            Raylib.CloseWindow();
        }

        public static bool ShouldClose()
        {
            if (Raylib.WindowShouldClose())
            {
                return true;
            }
            return false;
        }
        public static void BeginDrawing()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(_backgroundColor);
        }

        public static void EndDrawing()
        {
            Raylib.EndDrawing();
            

        }

        public static void BufferSwap()
        {
            Raylib.SwapScreenBuffer();
            Raylib.ClearBackground(_backgroundColor);
        }
        

        public static int HorizontalPixels { get { return _windowHozPixel; } set { _windowHozPixel = value; } }
        public static int VerticalPixels { get { return _windowVertPixel; } set { _windowVertPixel = value; } }
        public static Color BackgroundColor { get { return _backgroundColor; } set { _backgroundColor = value; } }
        public static string WindowTitle { get { return _windowTitle; } set { _windowTitle = value; } }

        


    }
}


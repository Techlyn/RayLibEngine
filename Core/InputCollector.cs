using System;
using System.Collections.Generic;
using System.Text;
using Raylib_cs;

namespace RayLibEngine.Core
{
    public static class InputCollector
    {

        public static void KeyboardInput()
        {


            if (Raylib.IsKeyPressed(KeyboardKey.Space))
            {
                
                Console.WriteLine($"Spacebar Key Pressed");
            }


            
            if (Raylib.IsKeyDown(KeyboardKey.W))
            {
                
                
            }
            if (Raylib.IsKeyDown(KeyboardKey.S))
            {

            }
            if (Raylib.IsKeyDown(KeyboardKey.A))
            {

            }
            if (Raylib.IsKeyDown(KeyboardKey.D))
            {

            }
            
            if (Raylib.IsKeyPressed(KeyboardKey.Tab))
            {

            }
            if (Raylib.IsKeyPressed(KeyboardKey.Escape))
            {

            }
            
            if (Raylib.IsKeyDown(KeyboardKey.LeftControl))
            {

            }
            if (Raylib.IsKeyDown(KeyboardKey.LeftShift))
            {

            }

            if (Raylib.IsKeyReleased(KeyboardKey.Enter))
            {

            }





        }

        public static void MouseInput()
        {
            Vector MoveInput = new Vector();


        }

    }
}

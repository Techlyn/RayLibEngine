using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Raylib_cs;

namespace RayLibEngine.Core;

public class SimpleBox
{
    
    public SimpleBox(Vector pos)
    {
        Raylib.DrawRectangle((int)pos.x, (int)pos.y, 50, 50, Color.Red);
    }
}

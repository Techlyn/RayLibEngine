using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


namespace RayLibEngine.Core
{
    public static class Clock
    {
        private static readonly Stopwatch _stopwatch = new Stopwatch();
        private static long _previousTicks;
        private static double _deltaTime;

        static Clock()
        {
            _stopwatch.Start();
            _previousTicks = _stopwatch.ElapsedTicks;
        }
       
    }
}

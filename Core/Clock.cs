using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


namespace RayLibEngine.Core
{
    public class Clock
    {
        private static readonly Stopwatch _stopwatch = new Stopwatch();
        private static long _previousTicks = _stopwatch.ElapsedTicks;
        private static double _deltaTime = 0;

        public Clock()
        {
            _stopwatch.Start();
        }
        

        public  void Tick()
        {
            long currentTick = _stopwatch.ElapsedTicks;
            _deltaTime = (currentTick - _previousTicks) / (double)Stopwatch.Frequency;
            _previousTicks = currentTick;
        }

        public double DeltaTime { get { return _deltaTime; } }

        public double TotalTime { get { return _stopwatch.ElapsedTicks / (double)Stopwatch.Frequency; } }

  
        
    }
}

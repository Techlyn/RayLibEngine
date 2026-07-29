using Raylib_cs;
using RayLibEngine.Core;
using System;
using System.Diagnostics;

using static RayLibEngine.Core.Logger;

namespace RayLibEngine;

internal static class Program
{

    static void Main(string[] args)
    {
        Logger.StartUp();


        long loopCount = 0;
        Stopwatch watch = Stopwatch.StartNew();

        do
        {
            loopCount++;
        }
        while (watch.ElapsedMilliseconds < 1000);

        watch.Stop();

        double secondsElapsed = watch.Elapsed.TotalMilliseconds / 1000.0;
        WriteLog($"elapsed time: {secondsElapsed}");
        WriteLog($"loop count: {loopCount}");
        WriteLog($"approximate loops per second: {loopCount / secondsElapsed}");

    }
    

}
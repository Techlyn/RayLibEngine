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
        //bool game_over = false;
        //int count = 0;
        //long adjust_time = 0;
        //int frame_time = 60;


        //while (!game_over)
        //{
        //    Clock.delta();

        //    long loop_time = Clock.split();
        //    long intended_sleep_time = frame_time - loop_time - adjust_time;

        //    if (intended_sleep_time > 0)
        //    {
        //        Clock.delta();
        //        Thread.Sleep((int)intended_sleep_time);
        //        long actual_sleep_time = Clock.split();

        //        adjust_time = actual_sleep_time - intended_sleep_time;
        //        if (adjust_time < 0)
        //        {
        //            adjust_time = 0;
        //        }
        //    }
        //    else
        //    {
        //        adjust_time = 0;
        //        Clock.delta();
        //    }
        //    if (count > 12000)
        //    {
        //        game_over = true;
        //    }
        //    WriteLog($"{loop_time}");
        //    count++;
        //}

        int i = 0;

        Stopwatch time;
        long tickThisTime = 0;

        while (i < int.MaxValue)
        {
            time = Stopwatch.StartNew();
            time.Stop();
            tickThisTime = time.ElapsedTicks;
            Console.WriteLine(tickThisTime);
        }


    }
    

}
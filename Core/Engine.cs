//using Raylib_cs;
//using System;
//using System.Collections.Generic;
using RayLibEngine.Core;
using System.Text;
using System.Text.RegularExpressions;
using static RayLibEngine.Core.Logger;

namespace RayLibEngine;

static class Engine
{
    private static double FIXED_FRAME_RATE = 60;
    private static double fixedDeltaTime = 1 / FIXED_FRAME_RATE;


    private static double accumulator = 0;
    private static int updateCount = 0;
    private static int renderCount = 0;


    public static void Run()
    {
        Clock clock = new Clock();

      

        int timeElapsed = 20;
        while (clock.TotalTime < timeElapsed)
        {
            clock.Tick();
            double dt = clock.DeltaTime;

            if (dt > 0.1) dt = 0.1; // dt cap

            TestUpdate(dt);
            TestRender();

        }
        WriteLog(LogLevel.LOG_DEBUG, $"Time Elapsed: {clock.TotalTime} Frame updates: {updateCount}");
        WriteLog(LogLevel.LOG_DEBUG, $"Time Elapsed: {clock.TotalTime} Frame renders: {renderCount}");

    }


    private static void TestUpdate(double deltaTime)
    {
        

        accumulator += deltaTime;

        while (accumulator >= fixedDeltaTime)
        {
            updateCount++;
            accumulator -= fixedDeltaTime;
        } 

    }

    private static void TestRender()
    {
        renderCount++;
    }


}

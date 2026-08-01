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

    private static bool _gameOver = false;
    private static long _count = 0;


    public static void StartUp()
    {
        DisplayManager.StartUp();
        
        TestObject test = new TestObject();
    }

    public static void Run()
    {
        Clock clock = new Clock();
        




        while (!_gameOver)
        {
            clock.Tick();
            double dt = clock.DeltaTime;

            if (dt > 0.1) dt = 0.1; // dt cap

            
            Update(dt);
            Render();

            if (DisplayManager.ShouldClose())
            {
                _gameOver = true;
            }
            _count++;

        }




    }

    


    private static void Update(double deltaTime)
    {
        InputCollector.KeyboardInput();

        accumulator += deltaTime;

        while (accumulator >= fixedDeltaTime)
        {
            EventStep es = new EventStep();
            es.StepCount = _count;
            Core.EventHandler.OnEvent(es);

            WorldGenerator.Update();

            accumulator -= fixedDeltaTime;
        } 

    }

    private static void Render()
    {
        //Not sure if Rendering will work like this while update is before, whether
        // update should happen before BeginDrawing or after. Will test both.
        DisplayManager.BeginDrawing();
        WorldGenerator.Draw();
        DisplayManager.EndDrawing();
        //DisplayManager.BufferSwap();
    }

  


}

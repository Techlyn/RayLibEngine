//using Raylib_cs;
//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Text.RegularExpressions;
//using static RayLibEngine.Logger;

//namespace RayLibEngine;

//static class Engine
//{
    
//    const string CLASS_NAME = "Engine";

//    private static bool game_over = false;
//    private static int FRAME_TIME_DEFAULT = 60;

    
//    static Engine() 
//    {
//        WriteLog(CLASS_NAME, LogLevel.LOG_INFO, $"Engine Started");
//    }


//    static public int StartUp()
//    {
//        Logger.StartUp();
//        WorldManager.StartUp();
//        DisplayManager.StartUp();

//        BoundingBox boundary = new Box();
//        boundary.setHoriziontal(DisplayManager.getHorizontal());
//        boundary.setVertical(DisplayManager.getVertical());
//        WorldManager.setBoundary(boundary);
//        WorldManager.setView(ValueMatch.getBoundry());

//        timeBeginPeriod(1);

//        WriteLog(LogLevel.LOG_INFO, "Game Manager Start");
//        return 0;
//    }

//    static public void Shutdown()
//    {
//        DisplayManager.Shutdown();
//        WorldManager.Shutdown();

//        SetGameOver();
//        timeEndPeriod(1);
//    }


//    static public void Run()
//    {
//        Clock clock;

//        long adjust_time = 0;
//        long count = 0;


//        while (!game_over)
//        {
//            clock.delta();

//            EventStep es;
//            es.SetStepCount(count);
//            OnEvent(es);
//            InputHandler.GetInput();
//            WorldManager.Update();
//            WorldManager.Draw();

//        }
//    }


//}

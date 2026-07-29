using Raylib_cs;
using RayLibEngine.Core;
using System;
using System.Diagnostics;
using System.Timers;
using static RayLibEngine.Core.Logger;

namespace RayLibEngine;

internal static class Program
{
    


    static void Main(string[] args)
    {   
        Logger.StartUp();
        Logger.SetGlobalLevel(LogLevel.LOG_DEBUG);

        Engine.Run();

        return;

       
    }

   


    
    
}


    


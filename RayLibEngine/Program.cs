using Raylib_cs;
using System;


namespace RayLibEngine;

internal static class Program
{

    static void Main(string[] args)
    {
        Logger.StartUp();

        Logger.WriteLog(LogLevel.LOG_NONE, "Test Log Text");

    }
    

}
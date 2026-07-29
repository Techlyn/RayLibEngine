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

        //Engine.Run();
        Vector test = new() { x = 0, y = 0 };
        Vector test2 = new() { x = 6, y = 20 };

        test.x = 5;
        test.y = 21;

        WriteLog($"Vector1 components: ({test.x}, {test.y})");
        WriteLog($"Vector2 components: ({test2.x}, {test2.y})");
        WriteLog($"Adding Vectors together and making that the new Vector2");

        if (test < test2) ;

        WriteLog($"Vector2 component ({test2.x}, {test2.y})");

        GameObject item = new GameObject();

        ObjectList<GameObject> items = new ObjectList<GameObject>();

        items.Insert(item);

        Console.WriteLine($"ObjectList should have 1 Object in it and should not be empty: {items.isEmpty}");
        


        return;


    }

   


    
    
}


    


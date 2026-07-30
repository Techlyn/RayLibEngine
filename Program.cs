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

        Engine.StartUp();

        Engine.Run();

        //VectorTest();
        //ObjectListTest();
        //ListIndexChangeTest();
        


        return;


    }

    static void VectorTest()
    {
        Vector test = new() { x = 0, y = 0 };
        Vector test2 = new() { x = 6, y = 20 };

        test.x = 5;
        test.y = 21;

        WriteLog($"Vector1 components: ({test.x}, {test.y})");
        WriteLog($"Vector2 components: ({test2.x}, {test2.y})");
        WriteLog($"Adding Vectors together and making that the new Vector2");

        test2 += test;

        WriteLog($"Vector2 component ({test2.x}, {test2.y})");
    }

    static void ObjectListTest()
    {
        GameObject item = new GameObject();

        ObjectList<GameObject> items = new ObjectList<GameObject>();

        items.Insert(item);

        Console.WriteLine($"ObjectList should have 1 Object in it and should not be empty: {items.isEmpty}");
        Console.WriteLine($"Number of objects in list is: {items.ObjectCount}");

        items.Remove(item);

        Console.WriteLine($"ObjectList should now be empty: {items.isEmpty}");
        Console.WriteLine($"Number in list is: {items.ObjectCount}");
    }


    static void ListIndexChangeTest()
    {
        List<int> list = new() { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine($"List Count: {list.Count}");
        Console.WriteLine($"Current List items are: ");
        foreach (int i in list) Console.Write($"{i} ");

        Console.WriteLine($"\nRemoving number at index: 3 which is: {list[3]}");
        list.RemoveAt(3);
        Console.WriteLine("Removed number at index: 3");
        foreach (int i in list) Console.Write($"{i} ");

        Console.WriteLine($"\nNew number at index: 3 is: {list[3]}");
        Console.WriteLine($"List Count is: {list.Count}");


    }
   


    
    
}


    


using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;

namespace RayLibEngine;

public enum LogLevel
{
    LOG_NONE = 0,
    LOG_ERROR,
    LOG_WARNING,
    LOG_INFO,
    LOG_DEBUG,
    LOG_TRACE
};

static class Logger
{

    public const string LOGFILE_NAME = "log.log";
    public const string CLASS_NAME = "Logger";

    private static LogLevel globalLevel = LogLevel.LOG_INFO;
    private static string path = "C:\temp";
    private static Dictionary<string, LogLevel> classLevels;

    private static bool _isStarted = false;

    public static bool isStarted()
    {
        return _isStarted;
    }

    public static void StartUp()
    {
        if (_isStarted) return;

        _isStarted = true;

        path = LogPathSetter();

    }


    public static void SetGlobalLevel(LogLevel level)
    {
        globalLevel = level;
        WriteLog(LogLevel.LOG_INFO, $"Global log level set to {LevelToString(level)}");
    }

    public static bool SetClassLevel(string className, LogLevel level)
    {
        if (globalLevel < LogLevel.LOG_NONE || globalLevel > LogLevel.LOG_TRACE)
        {
            WriteLog(LogLevel.LOG_ERROR, $"Attempt made to set log level {level} for class {className}");
            return false;
        }

        if (string.IsNullOrEmpty(className))
        {
            WriteLog(LogLevel.LOG_ERROR, "Class name empty on attempt");
            return false;
        }

        classLevels[className] = level;

        WriteLog(LogLevel.LOG_INFO, $"class [{className}] set to level [{level}]");
        return true;

    }

    public static string LevelToString(LogLevel level)
    {
        switch (level)
        {
            case LogLevel.LOG_NONE: return "NONE";
            case LogLevel.LOG_ERROR: return "ERROR";
            case LogLevel.LOG_WARNING: return "WARNING";
            case LogLevel.LOG_INFO: return "INFO";
            case LogLevel.LOG_DEBUG: return "DEBUG";
            case LogLevel.LOG_TRACE: return "TRACE";
            default:
                WriteLog(LogLevel.LOG_ERROR, "Error LogLevel not in range");
                break;

        }
        return "UNDEFINED";
    }

    public static bool ShouldLogClass(string className, LogLevel level)
    {
        if (classLevels.ContainsKey(className))
        {
            if (level <= classLevels.GetValueOrDefault(className))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        return false;
    }


    public static void WriteLog(string fmt, params object[] args)
    {
        string timeStamp = GetTimeString() + ":: ";

        string message = timeStamp + string.Format(fmt, args);

        Console.Error.WriteLine(message);

        string filePath = path + Path.DirectorySeparatorChar + LOGFILE_NAME;

        File.AppendAllLines(filePath, new List<string>() { message });

    }

    public static void WriteLog(LogLevel level, string fmt, params object[] args)
    {
        if (level > globalLevel) return;

        string levelStr = LevelToString(level);
        string message = string.Format(fmt, args);

        WriteLog($"[{levelStr}] {message}");
    }

    public static void WriteLog(string c_name, LogLevel level, string fmt, params object[] args)
    {
        if (!ShouldLogClass(c_name, level)) return;

        string message = string.Format(fmt, args);

        WriteLog(level, $"[{c_name}] [{message}]");
    }


    private static string GetTimeString()
    {
        return DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
    }

    private static string LogPathSetter()
    {
        string path = Directory.GetCurrentDirectory();
        string append = "\\log";
        string target = path + append;

        if (!Directory.Exists(target))
        {
            WriteLog($"Attempting to create Directory at {target}");
            Directory.CreateDirectory(target);
        }

        Console.WriteLine($"Target Set at {target}");
        return target;


    }


} //END OF CLASS LogManager


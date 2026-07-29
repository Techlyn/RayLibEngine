using System;
using System.Collections.Generic;
using System.Text;
using static RayLibEngine.Core.Logger;

namespace RayLibEngine.Core
{
    
    public class ObjectList<T>
    {
        private const int MAX_OBJECTS = 10;
        private readonly string CLASS_NAME = "ObjectList";
        private T[] arr = new T[MAX_OBJECTS];

        private int _count = 0;
        

        public T this[int i] 
        {
            get => arr[i];
            set => arr[i] = value;
        }

        public ObjectList()
        {
            // initialize array with defaults
            for (int i = 0; i < MAX_OBJECTS; i++) arr[i] = default;
        }

        public int Insert(T p_o)
        {
            if (_count == MAX_OBJECTS || p_o is null)
            {
                WriteLog(CLASS_NAME, LogLevel.LOG_ERROR, $"object insert failed!");
                return -1;
            }

            for (int i = 0; i < _count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(arr[i], p_o)) return -2;
            }
            arr[_count] = p_o;
            _count++;
            return _count - 1;
        }

        public int Remove(T p_o)
        {
            if (p_o is null)
            {
                WriteLog(CLASS_NAME, LogLevel.LOG_ERROR, $"object remove failed!");
                return -1;
            }

            for (int i = 0; i < _count; i++)
            {
                if (EqualityComparer<T>.Default.Equals(arr[i], p_o))
                {
                    for (int j = i; j < _count - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    arr[_count - 1] = default;
                    _count--;
                    return i;
                }
            }
            return -1;
        }

        public int ObjectCount { get { return _count; } }

        public bool isEmpty
        {
            get
            {
                for (int i = 0; i < MAX_OBJECTS; i++)
                {
                    if (arr[i] != null)
                    {
                        return false;
                    }
                }
                return true;
            }
            
        }

        public bool isFull
        {
            get
            {
                for (int i = 0; i < MAX_OBJECTS; i++)
                {
                    if (arr[i] == null) return false;
                }
                return true;
            }
        }

    }
}

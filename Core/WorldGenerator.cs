using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

using static RayLibEngine.Core.Logger;

namespace RayLibEngine.Core
{
    public static class WorldGenerator
    {
        private static List<GameObject> _updates = new List<GameObject>();
        private static List<GameObject> _deletions = new List<GameObject>();

        public static void Update()
        {
            for (int i = 0; i < _updates.Count; i++)
            {
                Vector new_pos = _updates[i].PredictPosition();
                if (new_pos != _updates[i].Position)
                {
                    MoveGameObject(_updates[i], new_pos);
                }

                _deletions.Clear();
            }
        }

        public static void InsertGameObject(GameObject obj)
        {
           
            if (!_updates.Any(child => obj == child)) _updates.Add(obj);
            else
                WriteLog(LogLevel.LOG_WARNING, "Attempting to add Object already in updates list");

        }

        private static void MoveGameObject(GameObject obj, Vector new_pos)
        {
            obj.Position = new_pos;
        }

        public static List<GameObject> ObjectsOfType(string type)
        {
            List<GameObject> list = new List<GameObject>();
            foreach (GameObject obj in _updates)
            {
                if (obj.Type == type)
                {
                    list.Add(obj);
                }
            }
            return list;
        }

        public static List<GameObject> AllObjects()
        {
            return _updates;
        }

        public static bool MarkForDelete(GameObject obj)
        {
            for (int i = 0; i < _updates.Count; i++)
            {
                if (_updates[i] == obj)
                {
                    _deletions.Add(obj);
                    _updates.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public static void MoveObject(GameObject obj, Vector new_pos)
        {
            obj.Position = new_pos;
        }

        public static void Draw()
        {
            foreach (GameObject obj in _updates)
            {
                obj.Draw();
            }
        }

    }





}

using System;
using System.Collections.Generic;
using System.Text;

namespace RayLibEngine.Core
{
    public class Vector
    {
        private float m_x;
        private float m_y;


        public Vector(float init_x, float init_y)
        {
            m_x = init_x;
            m_y = init_y;
        }

        public Vector()
        {
            m_x = 0;
            m_y = 0;
        }


        public float x { get { return m_x; } set { m_x = value; } }
        public float y { get { return m_y; } set { m_y = value; } }


        public static Vector operator +(Vector a, Vector b) => new Vector(a.x + b.x, a.y + b.y);
        public static Vector operator -(Vector a, Vector b) => new Vector(a.x - b.x, a.y - b.y);
        public static Vector operator *(Vector a, Vector b) => new Vector(a.x * b.x, a.y * b.y);
        public static Vector operator /(Vector a, Vector b) => new Vector(a.x / b.x, a.y / b.y);
        public static bool operator <(Vector a, Vector b) => (a.x < b.x) && (a.y < b.y);
        public static bool operator >(Vector a, Vector b) => (a.x > b.x) && (a.y > b.y);
        public static bool operator <=(Vector a, Vector b) => (a.x <= b.x) && (a.y <= b.y);
        public static bool operator >=(Vector a, Vector b) => (a.x >= b.x) && (a.y >= b.y);
        public static bool operator ==(Vector a, Vector b) => (Equals(a.x, b.x)) && (Equals(a.y, b.y));
        public static bool operator !=(Vector a, Vector b) => !(a == b);


    }
}

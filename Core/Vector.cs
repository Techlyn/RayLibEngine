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

        public float GetMagnitude()
        {
            double result = (double)(m_x * m_x + m_y * m_y);
            return (float)Math.Sqrt(result);
        }


        public Vector Normalize()
        {
            Vector v = new Vector(m_x, m_y);
            float length = GetMagnitude();
            if (length > 0)
            {
                v.x = m_x / length;
                v.y = m_y / length;
            }
            return v;
        }

        public Vector Scale(float s)
        {
            return new Vector(m_x * s, m_y * s);
        }


        public static Vector operator +(Vector a, Vector b) => new Vector(a.x + b.x, a.y + b.y);
        public static Vector operator -(Vector a, Vector b) => new Vector(a.x - b.x, a.y - b.y);
        public static Vector operator *(Vector a, Vector b) => new Vector(a.x * b.x, a.y * b.y);
        public static Vector operator /(Vector a, Vector b) => new Vector(a.x / b.x, a.y / b.y);
        public static bool operator <(Vector a, Vector b) => (a.x < b.x) && (a.y < b.y);
        public static bool operator >(Vector a, Vector b) => (a.x > b.x) && (a.y > b.y);
        public static bool operator <=(Vector a, Vector b) => (a.x <= b.x) && (a.y <= b.y);
        public static bool operator >=(Vector a, Vector b) => (a.x >= b.x) && (a.y >= b.y);
        public static bool operator ==(Vector a, Vector b)
        {
            if (a is null)
            {
                return b is null;
            }
            return a.Equals(b);
        }

        public static bool operator !=(Vector a, Vector b) => !(a == b);
        public bool Equals(Vector? other) => other is not null && other.x == x && other.y == y;
        public override bool Equals(object? obj) => Equals(obj as Vector);


    }
}

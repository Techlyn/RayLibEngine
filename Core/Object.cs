using System;
using System.Collections.Generic;
using System.Text;

// To add Animation, Event Registers, Collision/Boundaries, Sprite

namespace RayLibEngine.Core
{

    public enum Solidness
    {
        HARD,
        SOFT,
        SPECTRAL
    }

    internal class Object
    {
        private static int id_count = 0;
        private int m_id;
        private string m_type;
        private Vector m_position = new Vector();

        private int m_altitude = 1;
        private Vector m_direction = new Vector();
        private float m_speed = 0;
        private Solidness m_solidness = Solidness.HARD;
        private bool m_no_soft = false;

        private bool is_active = true;
        private bool is_visible = true;


        public int Id { get { return m_id; } set { m_id = value; } }

        public string Type { get { return m_type; } set { m_type = value; } }

        public Vector Position { get { return m_position; } set { m_position = value; } }

        public int Altitude { get { return m_altitude; } set { m_altitude = value; } }
        public Vector Direction { get { return m_direction; } set { m_direction = value; } }

        public float Speed { get { return m_speed; } set { m_speed = value; } }

        public Solidness NeedsANewName { get { return m_solidness; } set { m_solidness = value; } } //Name required.

        public bool Softness { get { return m_no_soft; } set { m_no_soft = value; } }

        public bool Active { get { return is_active; } set { is_active = value; } }
        public bool Visible { get { return is_visible; } set { is_visible = value; } }

        public Vector Velocity
        {
            get
            {
                Vector v = m_direction;
                v.Scale(m_speed);
                return v;
            }
            set
            {
                m_speed = value.GetMagnitude();
                m_direction = value.Normalize();
            }
        }

        public Vector PredictPosition()
        {
            Vector new_pos = m_position + Velocity;
            return new_pos;
        }


        public bool IsSolid()
        {
            if (m_solidness.Equals(Solidness.HARD) || m_solidness.Equals(Solidness.SOFT)) 
            {
                return true;
            }
            return false;

        }



    }

    

}

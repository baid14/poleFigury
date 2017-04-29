using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    public class Vector3D :Vector2D
    {
        private double z;
        public Vector3D(double x,double y,double z) :base(x,y)
        {
            this.z = z;
        }
        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }
        public override string ToString()
        {
            return "[" + x.ToString() + " , " + y.ToString() + " , " + z.ToString() + "]";
        }
        private static Vector3D toVector(Object obj)
        {
            if (obj is Vector3D)
            {
                Vector3D t_obj = obj as Vector3D;
                return t_obj;
            }
            throw new ArgumentException("Obiekt nie jest wektorem.");

        }
        public override bool Equals(object obj)
        {
            Vector3D t_obj = Vector3D.toVector(obj);
            if (this.x == t_obj.x && this.y == t_obj.y && this.z == t_obj.z) 
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public void draw()
        {
            Console.WriteLine("Rysuję wektor: " + this.ToString());
        }
        //TODO:??? sprawdzic to
        public int CompareTo(object obj)
        {
            Vector3D t_obj = Vector3D.toVector(obj);
            int cmp = this.x.CompareTo(t_obj.x);
            if (cmp == 0) 
                return this.y.CompareTo(t_obj.y);
            return cmp;
        }
        public static Vector3D operator +(Vector3D l, Vector3D r)
        {
            return new Vector3D(l.x + r.x, l.y + r.y,l.z+r.z);
        }

        public static Vector3D operator -(Vector3D l, Vector3D r)
        {
            return new Vector3D(l.x - r.x, l.y - r.y,l.z-r.z);
        }

        public static Vector3D operator *(Vector3D l, double a)
        {
            return new Vector3D(l.x * a, l.y * a,l.z*a);
        }

        public static Vector3D operator *(double a, Vector3D l)
        {
            return new Vector3D(l.x * a, l.y * a, l.z * a);
        }

        public static Vector3D operator /(Vector3D l, double a)
        {
            return new Vector3D(l.x / a, l.y / a,l.z/a);
        }

        public static Vector3D operator /(double a, Vector3D l)
        {
            return new Vector3D(a / l.x, a / l.y,a / l.z);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    public class Vector3D : IComparable, IDrawable
    {
        Vector2D _vector2d;
        double _z;
        public Vector3D(double x,double y,double z)
        {
            this._vector2d = new Vector2D(x, y);
            _z = z;
        }
        public double Z
        {
            get { return this._z; }
            set { this._z = value; }
        }
        public double X
        {
            get { return this._vector2d.X; }
            set { this._vector2d.X = value; }
        }
        public double Y
        {
            get { return this._vector2d.Y; }
            set { this._vector2d.Y = value; }
        }
        public override string ToString()
        {
            return "[" + _vector2d.X.ToString() + " , " + _vector2d.Y.ToString() + " , " + _z.ToString() + "]";
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
            if (this.X == t_obj.X && this.Y == t_obj.Y) return true;
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

        public int CompareTo(object obj)
        {
            Vector3D t_obj = Vector3D.toVector(obj);
            int cmp = this.X.CompareTo(t_obj.X);
            if (cmp == 0) return this.Y.CompareTo(t_obj.Y);
            return cmp;
        }

        /**
            Przeciążanie operatorów
        **/

        public static Vector3D operator +(Vector3D l, Vector3D r)
        {
            return new Vector3D(l._vector2d.X + r._vector2d.X, l._vector2d.Y + r._vector2d.Y,l.Z +l.Z);
        }

        public static Vector3D operator -(Vector3D l, Vector3D r)
        {
            return new Vector3D(l.X - r.X, l.Y - r.Y,l.Z-r.Z);
        }

        public static Vector3D operator *(Vector3D l, double a)
        {
            return new Vector3D(l.X * a, l.Y * a,l.Z*a);
        }

        public static Vector3D operator *(double a, Vector3D l)
        {
            return new Vector3D(l.X * a, l.Y * a, l.Z * a);
        }

        public static Vector3D operator /(Vector3D l, double a)
        {
            return new Vector3D(l.X / a, l.Y / a,l.Z/a);
        }

        public static Vector3D operator /(double a, Vector3D l)
        {
            return new Vector3D(a/l.X,a/l.Y,a/l.Z);
        }
    }
}

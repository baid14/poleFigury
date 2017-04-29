using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    /**
        Wektor przestrzeni 2D
    **/
    public class Vector2D:IComparable,IDrawable
    {
        protected double x;
        protected double y;

        public Vector2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        //gettery i settery

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        public override string ToString()
        {
            return "[" + x.ToString() + " , " + y.ToString() + "]";
        }

        private static Vector2D toVector(Object obj)
        {
            if (obj is Vector2D)
            {
                Vector2D t_obj = obj as Vector2D;
                return t_obj;
            }
            throw new ArgumentException("Obiekt nie jest wektorem.");

        }

        public override bool Equals(object obj)
        {
            Vector2D t_obj = Vector2D.toVector(obj);
            if (this.x == t_obj.x && this.y == t_obj.y) return true;
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
            Vector2D t_obj = Vector2D.toVector(obj);
            int cmp = this.x.CompareTo(t_obj.x);
            if (cmp == 0) return this.y.CompareTo(t_obj.y);
            return cmp;
        }

        /**
            Przeciążanie operatorów
        **/

        public static Vector2D operator +(Vector2D l, Vector2D r)
        {
            return new Vector2D(l.x + r.x, l.y + r.y);
        }

        public static Vector2D operator -(Vector2D l, Vector2D r)
        {
            return new Vector2D(l.x - r.x, l.y - r.y);
        }

        public static Vector2D operator *(Vector2D l, double a)
        {
            return new Vector2D(l.x*a, l.y*a);
        }

        public static Vector2D operator *(double a, Vector2D l)
        {
            return new Vector2D(l.x * a, l.y * a);
        }

        public static Vector2D operator /(Vector2D l, double a)
        {
            return new Vector2D(l.x / a, l.y / a);
        }

        public static Vector2D operator /(double a, Vector2D l)
        {
            return new Vector2D(l.x / a, l.y / a);
        }


    }
}

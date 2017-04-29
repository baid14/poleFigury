using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    public class Sphere : Shape
    {
        private Vector3D center;
        private double radius;

        public double Radius
        {
            get { return this.radius; }
            set { this.radius = value; }
        }

        public Vector3D Center
        {
            get { return this.center; }
            set { this.center = value; }
        }

        public Sphere(double r)
        {
            this.center = new Vector3D(0, 0, 0);
            this.radius = r;
        }

        public Sphere(Vector3D c, double r = 0)
        {
            this.center = c;
            this.radius = r;
        }

        public Sphere()
        {
            this.center = new Vector3D(0, 0, 0);
            this.radius = 0;
        }

        public override void draw()
        {
            Console.WriteLine("Rysuję kule o środku w: " + this.center.ToString() + " i promieniu: " + this.radius.ToString());
        }

        public override void translate(Vector2D t_vector)
        {
            //center.X = center.X + t_vector;
            this.center.X += t_vector.X;
            this.center.Y += t_vector.Y;
        }
        public override double Area
        {
            get
            {
                return 4 * Math.PI * radius * radius;
            }
        }
        public double Volume
        {
            get
            {
                return 4 / 3 * Math.PI * radius * radius * radius;
            }
        }
        public override string getDescription()
        {
            return "Kula: " + this.center.ToString() + " i promieniu: " + this.radius.ToString();
        }

        public void scale(double factor)
        {
            this.radius *= factor;
        }
    }
}

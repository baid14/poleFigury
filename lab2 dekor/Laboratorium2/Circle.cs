using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    public class Circle : Shape,IScalable
    {
        private Vector2D center;
        private double radius;

        public double Radius
        {
            get { return this.radius; }
            set { this.radius = value; }
        }

        public Vector2D Center
        {
            get { return this.center; }
            set { this.center = value; }
        }

        public Circle(double r)
        {
            this.center = new Vector2D(0, 0);
            this.radius = r;
        }

        public Circle(Vector2D c, double r=0)
        {
            this.center = c;
            this.radius = r;
        }

        public Circle()
        {
            this.center = new Vector2D(0, 0);
            this.radius = 0;
        }

        public override void draw()
        {
            Console.WriteLine("Rysuję okrąg o środku w: " + this.center.ToString() + " i promieniu: "+this.radius.ToString());
        }

        public override void translate(Vector2D t_vector)
        {
            this.center = this.center + t_vector;
        }

        public override double Area
        {
            get
            {
                return Math.PI * radius * radius;
            }
        }
        public override string getDescription()
        {
            return "Okrąg: " + this.center.ToString() + " i promieniu: " + this.radius.ToString();
        }

        public void scale(double factor)
        {
            this.radius *= factor;
        }
    }
}

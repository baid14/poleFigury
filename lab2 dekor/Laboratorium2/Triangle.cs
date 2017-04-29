using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    public class Triangle : Shape
    {
        Vector2D a;
        Vector2D b;
        Vector2D c;

        public Triangle(Vector2D a, Vector2D b, Vector2D c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override void draw()
        {
            Console.WriteLine("Rysuję trójkąt złożony z punktów:" + this.a.ToString() + " " + this.b.ToString() + " "+this.c.ToString());
        }

        public override void translate(Vector2D t_vector)
        {
            this.a = this.a + t_vector;
            this.b = this.b + t_vector;
            this.c = this.c + t_vector;
        }

        public override double Area
        {
            get
            {
                return 0.5 * Math.Abs((b.X-a.X)*(c.Y-a.Y)-(b.Y-a.Y)*(c.X-a.X));
            }
        }

        public override string getDescription()
        {
           return "To jest trójkąt złożony z punktów" + this.a.ToString() + " " + this.b.ToString() + " " + this.c.ToString();
        }
    }
}

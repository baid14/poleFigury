using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    public abstract class ShapeGenerator
    {
        public static Circle getCircle(Random r, out String desc, double multiplier=1)
        {
            Vector2D center;
            double radius = r.NextDouble() * multiplier;
            center= new Vector2D(r.NextDouble() * multiplier, r.NextDouble() * multiplier);
            desc = "Wylosowano okrąg o środku: " + center.ToString() + " i promieniu " + radius.ToString();
            return new Circle(center, radius);
        }

        public static Triangle getTriangle(Random r, out String desc, double multiplier = 1)
        {
            Vector2D a;
            Vector2D b;
            Vector2D c;
            
            a = new Vector2D(r.NextDouble() * multiplier, r.NextDouble() * multiplier);
            b = new Vector2D(r.NextDouble() * multiplier, r.NextDouble() * multiplier);
            c = new Vector2D(r.NextDouble() * multiplier, r.NextDouble() * multiplier);

            desc = "Wylosowano trójkąt o wierzchołkach " + a + " " + b +" " + c;
            return new Triangle(a, b, c);
        }
        public static Ball getBall(Random r, out String desc, double multiplier = 1)
        {
            Vector3D center;
            double radius = r.NextDouble() * multiplier;
            center = new Vector3D(r.NextDouble() * multiplier, r.NextDouble() * multiplier, r.NextDouble() * multiplier);

            desc = "Wylosowano kule o środku: " + center.ToString() + " i promieniu " + radius.ToString();
            return new Ball(center, radius);
        }
    }
}

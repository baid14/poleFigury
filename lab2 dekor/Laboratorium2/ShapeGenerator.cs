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
        public static Sphere getSphere(Random r, out String desc, double multiplier = 1)
        {
            Vector3D center;
            double radius = r.NextDouble() * multiplier;
            center = new Vector3D(r.NextDouble() * multiplier, r.NextDouble() * multiplier, r.NextDouble() * multiplier);
            desc = "Wylosowano kulę o środku: " + center.ToString() + " i promieniu " + radius.ToString();
            return new Sphere(center, radius);
        }

        public static Poligon getPoligon(Random r, out String desc, double multiplier = 1)
        {
            List<Vector2D> list = new List<Vector2D>();
            double n;
            do
                n = r.Next(7); //max liczba wierzchołków
            while (n < 4);
            //min liczba wierzchołków 
            double x, y;
            for (int i = 0; i < n; i++)
            {
                if(i!=0)
                {
                    x = list[i - 1].X;
                    y = list[i - 1].Y;
                }
                else
                {
                    x = 0;
                    y = 0;
                }
                list.Add(new Vector2D(x+ (r.NextDouble() * 2.0 - 1.0) * multiplier, y+ (r.NextDouble() * 2.0 - 1.0) * multiplier));
            }
            string s = "";
            foreach (Vector2D v in list)
                s += v.ToString() + " ";
            desc = "Wylosowano wielokat o " + list.Count + " wierzcholkach:  " + s;
            return new Poligon(list);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    class Program
    {
        static double multiplier = 10.0;
        static void Main(string[] args)
        {
            Random generator;
            List<Shape> shapeList;
            String outdesc;

            shapeList = new List<Shape>();
            generator = new Random();
            Shape t_s;

            for(int i = 0; i < 10; i++)
            {
                double ds = generator.NextDouble();
                if (ds < 0.33)
                    t_s=ShapeGenerator.getCircle(generator, out outdesc, multiplier);
                else if (ds >= 0.33 && ds<0.66)
                    t_s = ShapeGenerator.getTriangle(generator, out outdesc, multiplier);
                else 
                    t_s = ShapeGenerator.getBall(generator, out outdesc, multiplier);
                shapeList.Add(t_s);
                Console.WriteLine(outdesc);
            }

            Console.ReadKey();

            ShapePrinter S = ShapePrinter.getInstance();
            S.readShapeList(shapeList);
            Console.ReadLine();
        }
    }
}

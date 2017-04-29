using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    public class ShapePrinter
    {
        private int readedShapes;
        private static ShapePrinter instance = null;

        private ShapePrinter()
        {
            readedShapes = 0;
        }


        public static ShapePrinter getInstance()
        {
            if (instance == null) instance = new ShapePrinter();
            return instance;
        }

        public void reset()
        {
            instance = null;
        }

        private void readTriangle(Triangle T)
        {
            Console.WriteLine("Trojkat!\t" + T.getDescription());
        }

        private void readCircle(Circle C)
        {
            Console.WriteLine("Okrag!\t" + C.getDescription());
        }

        private void readUnknown(Shape X)
        {
            Console.WriteLine("Nieznany kształt!\t" + X.ToString());
        }

        private void readCurrentShape(Shape S)
        {
            if (S is Triangle)
            {
                readTriangle(S as Triangle);
                readedShapes++;
            }
            else if (S is Circle)
            {
                readCircle(S as Circle);
                readedShapes++;
            }
            else
            {
                readUnknown(S);
            }
        }

        public void readShapeList(List <Shape> list)
        {
            foreach(Shape S in list)
            {
                readCurrentShape(S);
            }
            Console.WriteLine("Wyświetlono informacje o " + readedShapes.ToString() + "kształtach.");
        }
    }
}

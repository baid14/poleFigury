using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    public class Poligon : Shape
    {
        List<Vector2D> _poligonList = new List<Vector2D>();

        public Poligon(List<Vector2D> l)
        {
            _poligonList = l;
        }
        public override void translate(Vector2D t_vector)
        {
            for(int i=0;i<_poligonList.Count;i++)
                _poligonList[i] += t_vector;            
        }

        public override double Area
        {
            //wierzchołki muszą być uporządkowane, żeby dobrze liczyło
            get
            {
                double wynik = 0.0;
                for (int i = 0; i < this._poligonList.Count() - 2; i++)
                {
                    wynik += 0.5 * Math.Abs((_poligonList[i + 1].X - _poligonList[0].X) * (_poligonList[i + 2].Y - _poligonList[0].Y) 
                        - (_poligonList[i + 1].Y - _poligonList[0].Y) * (_poligonList[i + 2].X - _poligonList[0].X));
                }
                return wynik;
            }
        }

        public override void draw()
        {
            Console.WriteLine("Rysuję wielokat o wierzchołkach: ");
            foreach (Vector2D vect in this._poligonList)
            {
                System.Console.WriteLine(vect.ToString());
            }
        }
        public override String getDescription()
        {
            string s = " ";
            foreach (Vector2D v in this._poligonList)
            {
                s += " " + v.ToString();
            }
            return "Wielokat o wierzcholkach:" + s;
        }
    }
}

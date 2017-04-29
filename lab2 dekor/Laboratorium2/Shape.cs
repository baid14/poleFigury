using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorium2
{
    /**

        Klasa reprezentująca dowolną figurę geometryczną

    **/

    public abstract class Shape : IDrawable
    {

        public abstract void translate(Vector2D t_vector);

        public abstract void draw();

        public virtual double Area
        {
            get { return 0; }
        }

        public virtual String getDescription()
        {
            return "To jest zwykły kształt";
        }
    }
}

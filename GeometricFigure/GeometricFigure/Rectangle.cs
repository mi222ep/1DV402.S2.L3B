using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    class Rectangle : Shape
    {
        public override double Area { get { return 54;} }
        public override double Perimeter { get{ return 43;}}
        public Rectangle (double lenght, double width)
            :base (lenght, width)
        {

        }
    }
}

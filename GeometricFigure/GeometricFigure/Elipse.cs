using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    class Elipse : Shape
    {
        public override double Area { get { return 54;} }
        public override double Perimeter { get{ return 43;}}
        public Elipse(double lenght, double width)
            :base (lenght, width)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    class Rectangle : Shape
    {
        public override double Area
        {
            get
            {
                return Lenght * Width;
            }
        }
        public override double Perimeter
        {
            get
            {
                return (Width*2)+(Lenght*2);
            }
        }
        public Rectangle (double lenght, double width)
            :base (lenght, width)
        {

        }
    }
}

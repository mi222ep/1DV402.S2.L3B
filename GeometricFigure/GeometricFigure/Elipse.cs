using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    class Elipse : Shape
    {
        public override double Area
        {
            get
            {
                double a = Lenght / 2;
                double b = Width / 2;
                return Math.PI * a * b;
            }
        }
        public override double Perimeter
        {
            get
            {
                double a = Lenght / 2;
                double b = Width / 2;
                return Math.PI * Math.Sqrt(2 * a * a + 2 * b * b);
            }
        }
        public Elipse(double lenght, double width)
            :base (lenght, width)
        {
        }
    }
}

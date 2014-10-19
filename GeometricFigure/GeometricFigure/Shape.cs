using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    abstract class Shape
    {
        double _lenght;
        double _width;

        public abstract double Area { get; }
        public double Lenght
        {
            get { return _lenght; }
            set
            {
                _lenght = Lenght;
            }
        }
        public abstract double Perimeter { get; }
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = Width;
            }
        }

        public int CompareTo(object obj)
        {
            return 12;
        }
        protected Shape(double lenght, double width)
        {
            Lenght = lenght;
            Width = width;
        }
        public override string ToString()
        {
            return ("string");
        }

    }
}

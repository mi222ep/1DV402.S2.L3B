using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    public enum ShapeType { Elipse, Rectangle };
    abstract class Shape

    {
        private double _lenght;
        private double _width;

        public abstract double Area { get; }
        public double Lenght
        {
            get { return _lenght; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException();
                }
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
                 if (value < 1)
                {
                    throw new ArgumentException();
                }
                _width = Width;
            }
        }
        protected Shape(double lenght, double width)
        {
            //Inga värden sparas, VARFÖR?!
            Lenght = lenght;
            Width = width;
        }
        public override string ToString()
        {
            return string.Format("\nLängd : {0}\nBredd : {1} \nOmkrets : {2} \nArea : {3}", _lenght, _width, Perimeter, Area);
            //Längd : Length
            //Bredd : Width
            //Omkrets: Perimeter
            //Area : Area
        }

    }
}

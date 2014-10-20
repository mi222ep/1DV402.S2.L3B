using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    enum ShapeType { Indefinite, Elipse, Rectangle };
    class Program
    {
        static void Main(string[] args)
        {
             bool exit = false;
            ShapeType type = ShapeType.Indefinite;

            do
            {
                switch (GetMenuChoice())
                {
                    case 0:
                        exit = true;
                        continue;

                    case 1:
                        type = ShapeType.Rectangle;
                        break;
                        
                    case 2:
                        type = ShapeType.Elipse;
                        break;
                }

                Console.Clear();
                

            } while (!exit);
        }

private static int GetMenuChoice()
{
 	throw new NotImplementedException();
}

        }
    }
}

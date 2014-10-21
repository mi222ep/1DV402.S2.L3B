using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            //Användaren skall själv kunna ange menyval
            int menuChoise = 2;
            
            bool exit = false;
            ShapeType type = ShapeType.Rectangle;
            do
            {
                ViewMenu();
                switch (menuChoise)
                {
                    case 0:
                        exit = true;
                        continue;

                    case 1:
                        type = ShapeType.Elipse;
                        break;

                    case 2:
                        type = ShapeType.Rectangle;
                        break;
                    default:
                        Console.WriteLine("Vänligen ange menyalternativ 0, 1 eller 2");
                        continue;
                }
                Shape obj = CreateShape(type);
                ViewShapeDetail(obj);
                Console.WriteLine("Press any key to continue");
                Console.ReadKey(true);
                Console.Clear();

            }
            while (!exit);
            
        }
        private static Shape CreateShape(ShapeType shapeType)
        {
            double lenght = ReadDoubleGreaterThanZero("\nVänligen ange objektets längd: ");
            double width = ReadDoubleGreaterThanZero("\nVänligen ange objektets bredd: ");

            //Behövs en if-sats? Kan shapeType användas på annat sätt här?
            //Olika objekt beroende på shapetype

            Rectangle obj = new Rectangle(lenght, width);
            return obj;

        }
        public static double ReadDoubleGreaterThanZero(string prompt)
        {
            {
                double index;

                do
                {
                    Console.Write(prompt);
                    if (double.TryParse(Console.ReadLine(), out index) && index >= 0)
                    
                    {
                        return index;
                    }

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\n FEL! Ange ett nummer större än noll.\n");
                    Console.ResetColor();
                } while (true);
            }
        }
        private static void ViewMenu()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ╔═══════════════════════════════════╗ ");
            Console.WriteLine(" ║          Geometriska figurer      ║ ");
            Console.WriteLine(" ╚═══════════════════════════════════╝ ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" 0. Avsluta.");
            Console.WriteLine(" 1. Ellips.");
            Console.WriteLine(" 2. Rektangel.");
            Console.WriteLine("\n ═══════════════════════════════════════════\n");
            Console.Write(" Ange menyval [0-2]: ");
            Console.ResetColor();
        }
        private static void ViewShapeDetail(Shape shape)
        {
            string info = shape.ToString();

            Console.WriteLine(info);
        }
    }
}
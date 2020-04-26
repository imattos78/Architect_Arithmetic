using System;

namespace Architect_Arithmetic
{
    class Program
    {
        static double Rect(double length, double width)
        {
            double area = length * width;
            return area;
        }
        static double Circle(double radius)
        {
            double areaCircle = Math.PI * Math.Pow(radius, 2);
            double semiCircle = areaCircle / 2;
            return semiCircle;
        }
        static double Triangle(double bottom, double height)
        {
            double areaTriangle = 0.5 * bottom * height;
            return areaTriangle;
        }
        static double Cube(double side)
        {
            double areaCube = Math.Pow(side, 2);
            return areaCube;
        }
        static void CalculateTotalCost()
        {
            //TEOTIHUACAN
            double totalAreas = Rect(1500, 2500) + Circle(375) + Triangle(750, 500);
            double totalMaterial = Math.Round((totalAreas * 180), 2);

            //TAJ MAHAL
            double tajArea = Cube(90.5) + (Cube(24) * 2);
            double tajMaterial = Math.Round((tajArea * 180), 2);

            //MECCA
            double meccaArea = Triangle(84, 264) + (Rect(264, 306) - Rect(84, 106));
            double meccaMaterial = Math.Round((meccaArea * 180), 2);

            //User Selection
            Console.Write("What monument would you like to work with?: ");
            string monument = Console.ReadLine();
            if (monument == "Teotihuacan")
            {
                Console.WriteLine($"The total area of the project is {totalAreas} m2 and the cost of materials: {totalMaterial} pesos");
            }
            else if (monument == "Taj Mahal")
            {
                Console.WriteLine($"The total area of the project is {tajArea} m2 and the cost of materials: {tajMaterial} pesos");

            }
            else if (monument == "Mecca")
            {
                Console.WriteLine($"The total area of the project is {meccaArea} m2 and the cost of materials: {meccaMaterial} pesos");

            }
        }
        public static void Main(string[] args)
        {

            CalculateTotalCost();

        }
    }
}

using System;

namespace Prac2
{
    class Program
    {
        enum TypeTriangle
        {
            Equilateral,
            Isosceles,
            Versatile
        }

        static public double a = 0, b = 0, c = 0, areaTriangle = 0;
        static TypeTriangle triangle = TypeTriangle.Versatile;
        static void Main(string[] args)
        {
            

            while (!CheckingСorrectness());

            DetermineTypeTriangle(a, b, c, ref triangle);
            areaTriangle = AreaTriangle(a, b, c);
            Console.WriteLine($"Треугольник является: {triangle}");
            Console.WriteLine($"Площадь треугольника: {areaTriangle}");
        }

        static bool CheckingСorrectness()
        {
            bool itIsNumber = double.TryParse(Console.ReadLine(), out double a) &
            double.TryParse(Console.ReadLine(), out double b) &
            double.TryParse(Console.ReadLine(), out double c);
            bool greaterZero = a > 0 && b > 0 && c > 0;
            bool matchingLengthsSides = a + b > c && a + c > b && b + c > a;

            if (itIsNumber && greaterZero && matchingLengthsSides)
            {
                return true;
            }

            else
            {
                Console.WriteLine("Incorrect input. Try again");
                return false;
            }
        }

        static void DetermineTypeTriangle(double a, double b, double c, ref TypeTriangle triangle)
        {
            if ((a == b) && (b == c)) triangle = TypeTriangle.Equilateral;
            else if ((a == b) || (b == c) || (a == c)) triangle = TypeTriangle.Isosceles;
            else triangle = TypeTriangle.Versatile;
        }

        static double AreaTriangle(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}

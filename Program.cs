using System.Formats.Asn1;

namespace asignment_1._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double squareLength = 5.5;
            double result = SquareArea(squareLength);
            Console.WriteLine("Area of the square.");
            Console.WriteLine(result);

            double rectangleLength = 7.5;
            double rectangleHeight = 8.5;
            double result1 = (rectangleLength * rectangleHeight);
            Console.WriteLine("Area of the rectangle.");
            Console.WriteLine(result1);

            double triangleBase = .5 * 5;
            double triangleHeight = 6;
            double result2 = (triangleBase * triangleHeight);
            Console.WriteLine("Area of the triangle");
            Console.WriteLine(result2);

        }

        static double SquareArea(double length)
        {
            double area = length * length;
             
            return area;

            

        }


    }
}

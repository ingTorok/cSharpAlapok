using System;

namespace _02SikiidmokTerulete
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(side: 4);
            Console.WriteLine($"Area of the square: {square.Area()}");

            var circle = new Circle(radius: 5);
            Console.WriteLine($"Area of the circle: {circle.Area()}");

            var triangle = new Triangle(trianglebase: 3, height: 3);
            Console.WriteLine($"Area of the triangle: {triangle.Area()}");

            Console.ReadLine();
        }
    }
}

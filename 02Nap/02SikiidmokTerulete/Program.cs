using System;
using System.Collections.Generic;

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

            var triangle = new Triangle(trianglebase: 6, height: 4);
            Console.WriteLine($"Area of the triangle: {triangle.Area()}");

            var areaSum = square.Area();

            areaSum = areaSum + circle.Area();

            areaSum += triangle.Area();

            Console.WriteLine($"Sum of the areas: {areaSum}");

            var planes = new List<IPlane>();

            planes.Add(square);
            planes.Add(circle);
            planes.Add(triangle);

            var sum = 0;

            foreach (var plane in planes)
            {
                sum += plane.Area();
            }

            Console.WriteLine($"Sum of the areas: {sum}");

            Console.ReadLine();
        }
    }
}

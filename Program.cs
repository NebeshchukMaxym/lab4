using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(new Point(0, 5), 7, "Red");
            Console.WriteLine(square);
            Console.WriteLine($"Angles: [ {string.Join(", ", square.GetCornersAngles())} ]");
            Console.WriteLine($"Point(1, 1) is {(square.Contains(new Point(1, 1)) ? "" : "not")} within {square}");
            Console.WriteLine();

            Ellipse ellipse = new Ellipse(new Point(7, 3), 5, 10, "Green");
            Console.WriteLine(ellipse);
            Console.WriteLine($"Circumference Length: {ellipse.GetCircumferenceLength()}");
            Console.WriteLine($"Point(1, 1) is {(ellipse.Contains(new Point(1, 1)) ? "" : "not")} within {ellipse}");
            Console.WriteLine();

            Triangle triangle = new Triangle(new Point(0, 0), new Point(1, 2), new Point(-1, 5), "Yellow");
            Console.WriteLine(triangle);
            Console.WriteLine($"Angles: [ {string.Join(", ", triangle.GetCornersAngles())} ]");
            Console.WriteLine($"Point(1, 1) is {(triangle.Contains(new Point(1, 1)) ? "" : "not")} within {triangle}");
            Console.WriteLine();

            Quadrilateral quadrilateral = new Quadrilateral(new Point(1, 2), new Point(2, 2), new Point(-3, 5), new Point(-3, -5), "Blue");
            Console.WriteLine(quadrilateral);
            Console.WriteLine($"Angles: [ {string.Join(", ", quadrilateral.GetCornersAngles())} ]");
            Console.WriteLine($"Point(1, 1) is {(quadrilateral.Contains(new Point(1, 1)) ? "" : "not")} within {quadrilateral}");
            Console.WriteLine();
        }
    }
}

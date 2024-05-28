using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 4);
        Rectangle rectangle = new Rectangle(6, 4, "Green");
        Circle circle = new Circle(2, "Grey");

        List<Shape> shapes = new List<Shape>();

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape sh in shapes)
        {
            double disshape = sh.GetArea();
            string discolor = sh.GetColor();

            Console.WriteLine($"The {discolor} color has an area of {disshape}.");
        }
    }
}
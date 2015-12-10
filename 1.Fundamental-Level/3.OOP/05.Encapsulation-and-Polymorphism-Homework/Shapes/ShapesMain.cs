using System;
using Shapes.Interfaces;
using Shapes.Models;

namespace Shapes
{
    public class ShapesMain
    {
        public static void Main()
        {
            Console.Title = "Problem 1.	Shapes";

            IShape[] shapes =
            {
                new Circle(5),
                new Rectangle(8.3, 8.1),
                new Rhombus(5, 6)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("{0} area = {1:F2}",
                    shape.GetType().Name, shape.CalculateArea());
                Console.WriteLine("{0} perimeter = {1:F2}",
                    shape.GetType().Name, shape.CalculateArea());
            }
        }
    }
}

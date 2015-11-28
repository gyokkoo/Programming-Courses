using System;

namespace _01.Point3D
{
    public class Point3DMain
    {
        public static void Main()
        {
            Console.Title = "Problem 1.	Point3D";

            Console.WriteLine("Starting point -> {0}", Point3D.StartingPoint);

            Point3D firstPoint = new Point3D(5, 10, 2.5);
            Console.WriteLine("First 3D point -> " + firstPoint.ToString());

            Point3D secondPoint = new Point3D(-2, -3, -10);
            Console.WriteLine("Second 3D point -> " + secondPoint.ToString());
        }
    }
}

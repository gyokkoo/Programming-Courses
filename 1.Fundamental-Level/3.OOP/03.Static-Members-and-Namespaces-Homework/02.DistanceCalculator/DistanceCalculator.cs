using System;
using _01.Point3D;

public class DistanceCalculator
{
    public static double CalculateDistance(Point3D p1, Point3D p2)
    {
        double distance = Math.Sqrt(
            Math.Pow(p2.X - p1.X, 2) +
            Math.Pow(p2.Y - p1.Y, 2) +
            Math.Pow(p2.Z - p1.Z, 2));

        return distance;
    }
}

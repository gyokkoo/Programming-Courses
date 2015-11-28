using System;
using _01.Point3D;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

static class Storage
{
    public static List<Point3D> LoadPaths(string path)
    {
        List<Point3D> points = new List<Point3D>();
        string file = File.ReadAllText(path);

        Regex regex = new Regex(@"\[(-?\d*\.{0,1}\d+), (-?\d*\.{0,1}\d+), (-?\d*\.{0,1}\d+)\]");
        foreach (Match match in regex.Matches(file))
        {
            double x = double.Parse(match.Groups[1].Value);
            double y = double.Parse(match.Groups[2].Value);
            double z = double.Parse(match.Groups[3].Value);

            Point3D point = new Point3D(x, y, z);
            points.Add(point);
        }

        return points;
    }

    public static void SavePath(string destination, Path3D path)
    {
        File.AppendAllText(destination, path.ToString());
    }
}

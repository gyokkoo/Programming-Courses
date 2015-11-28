using System;
using System.Collections.Generic;
using _01.Point3D;
using System.Text;

public class Path3D
{
    private List<Point3D> points;

    public Path3D(List<Point3D> points)
    {
        this.Points = points;
    }

    public List<Point3D> Points
    {
        get
        {
            return this.points;
        }
        set
        {
            this.points = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        foreach (var point in Points)
        {
            sb.AppendLine(point.ToString());
        }

        return sb.ToString();
    }
}

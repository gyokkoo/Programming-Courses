using System;

namespace _01.Point3D
{
    public class Point3D
    {
        private static readonly Point3D StartingPointCoordinates;

        static Point3D()
        {
            StartingPointCoordinates = new Point3D(0, 0, 0);
        }

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Point3D StartingPoint
        {
            get
            {
                return Point3D.StartingPointCoordinates;
            }
        }

        public override string ToString()
        {
            string result = String.Format(
                "[{0}, {1}, {2}]", this.X, this.Y, this.Z);

            return result;
        }
    }
}
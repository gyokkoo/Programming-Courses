namespace CohesionAndCoupling.Geometry
{
    using System;

    public static class Geometry3DUtils
    {
        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;
            double deltaZ = z2 - z1;

            double distance = Math.Sqrt((deltaX * deltaX) + (deltaY * deltaY) + (deltaZ * deltaZ));

            return distance;
        }

        public static double CalcVolume(Figure3D figure)
        {
            double volume = figure.Width * figure.Height * figure.Depth;

            return volume;
        }

        public static double CalcDiagonalXYZ(Figure3D figure)
        {
            double distance = CalcDistance3D(0, 0, 0, figure.Width, figure.Height, figure.Depth);

            return distance;
        }

        public static double CalcDiagonalXY(Figure3D figure)
        {
            double distance = Geometry2DUtils.CalcDistance2D(0, 0, figure.Width, figure.Height);

            return distance;
        }

        public static double CalcDiagonalXZ(Figure3D figure)
        {
            double distance = Geometry2DUtils.CalcDistance2D(0, 0, figure.Width, figure.Depth);

            return distance;
        }

        public static double CalcDiagonalYZ(Figure3D figure)
        {
            double distance = Geometry2DUtils.CalcDistance2D(0, 0, figure.Height, figure.Depth);

            return distance;
        }
    }
}

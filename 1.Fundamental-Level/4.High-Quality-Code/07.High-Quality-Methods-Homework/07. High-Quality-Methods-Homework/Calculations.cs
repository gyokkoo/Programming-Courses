namespace Methods
{
    using System;

    public static class Calculations
    {
        public static double CalculateTriangleArea(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
            {
                throw new ArgumentException("The triangle sides must be positive");
            }

            double perimeter = (firstSide + secondSide + thirdSide) / 2;
            double area =
                Math.Sqrt(perimeter * (perimeter - firstSide) * (perimeter - secondSide) * (perimeter - thirdSide));

            return area;
        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double horizontalDifference = x2 - x1;
            double verticalDifference = y2 - y1;

            //Find the distance using Pythagoras theorem
            double distance = Math.Sqrt(Math.Pow(horizontalDifference, 2) + Math.Pow(verticalDifference, 2));

            return distance;
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("The array length cannot be null.");
            }

            int maxNumber = int.MinValue;
            for (int currentIndex = 1; currentIndex < elements.Length; currentIndex++)
            {
                if (elements[currentIndex] > maxNumber)
                {
                    maxNumber = elements[currentIndex];
                }
            }

            return maxNumber;
        }

        public static bool IsVertical(double x1, double x2)
        {
            return x1.Equals(x2);
        }

        public static bool IsHorizontal(double y1, double y2)
        {
            return y1.Equals(y2);
        }
    }
}

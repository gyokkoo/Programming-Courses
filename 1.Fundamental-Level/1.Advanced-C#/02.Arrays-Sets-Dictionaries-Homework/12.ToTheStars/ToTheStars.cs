using System;
using System.Collections.Generic;

/*
This problem is from the JavaScript Basics Exam (4 September 2014). 
You may check your solution here.
*/
class ToTheStars
{
    static void Main()
    {
        string[] starNames = new string[3];
        double[] starCoordinatesX1 = new double[3];
        double[] starCoordinatesY1 = new double[3];

        for (int i = 0; i < 3; i++)
        {
            string[] inputLine = Console.ReadLine().Split(' ');
            starNames[i] = inputLine[0];
            starCoordinatesX1[i] = double.Parse(inputLine[1]);
            starCoordinatesY1[i] = double.Parse(inputLine[2]);
        }

        string[] shipCoordinates = Console.ReadLine().Split(' ');
        double shipCoordinateX1 = double.Parse(shipCoordinates[0]);
        double shipCoordinateY1 = double.Parse(shipCoordinates[1]);

        int shipMoves = int.Parse(Console.ReadLine());

        NavigationInStars(shipMoves, shipCoordinateX1, starCoordinatesX1, shipCoordinateY1, starCoordinatesY1, starNames);
    }

    static void NavigationInStars(int shipMoves, double shipCoordinateX1,
                                double[] starCoordinatesX1, double shipCoordinateY1,
                                double[] starCoordinatesY1, string[] starNames)
    {
        for (int i = 0; i <= shipMoves; i++)
        {
            bool isInRange = false;

            for (int j = 0; j < 3; j++)
            {
                if (IsInsideStar(shipCoordinateX1, starCoordinatesX1, shipCoordinateY1, starCoordinatesY1, j))
                {
                    Console.WriteLine(starNames[j].ToLower());
                    isInRange = true;
                }
            }

            if (!isInRange)
            {
                Console.WriteLine("space");
            }
            shipCoordinateY1++;
        }
    }

    static bool IsInsideStar(double shipCoordinateX1, double[] starCoordinatesX1,
        double shipCoordinateY1, double[] starCoordinatesY1, int j)
    {
        bool isInsideStar = ((shipCoordinateX1 <= starCoordinatesX1[j] + 1) &&
                            (shipCoordinateX1 >= starCoordinatesX1[j] - 1) &&
                            (shipCoordinateY1 >= starCoordinatesY1[j] - 1) &&
                            (shipCoordinateY1 <= starCoordinatesY1[j] + 1));

        return isInsideStar;
    }
}


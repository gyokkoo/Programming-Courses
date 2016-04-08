namespace _07.ConnectedAreasInMatrix
{
    using System;
    using System.Collections.Generic;

    public class ConnectedAreas
    {
        private static readonly char[,] Matrix =
            {
                { ' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ' },
                { ' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ' },
                { ' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ' },
                { ' ', ' ', ' ', ' ', '*', ' ', '*', ' ', ' ' },
            };

        // Ctrl + K + U Uncomment
        // Ctrl + K + C Comment

        //private static readonly char[,] Matrix =
        //    {                                                
        //        { '*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
        //        { '*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
        //        { '*', ' ', ' ', '*', '*', '*', '*', '*', ' ', ' '},
        //        { '*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
        //        { '*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
        //    };

        private const char EmpyCellSymbol = ' ';
        private const char VisitedCellSymbol = 'V';

        private static readonly SortedSet<Area> Areas = new SortedSet<Area>();

        public static void Main()
        {
            int[] coordinates = new int[2];
            while (HasUnvisitedCell())
            {
                FindFirstUnvisitedArea(coordinates);
                int startRow = coordinates[0];
                int startCol = coordinates[1];
                var area = new Area(startRow, startCol, 0);
                TraverseUnvisitedArea(area, startRow, startCol);
                Areas.Add(area);
            }
            
            Console.WriteLine("Total areas found: {0}", Areas.Count);
            int areaNumber = 1;
            foreach (var area in Areas)
            {
                Console.WriteLine("Area {0} at ({1}, {2}), size {3}", areaNumber, area.Row, area.Col, area.Size);
                areaNumber++;
            }
        }

        private static void TraverseUnvisitedArea(Area area, int row, int col)
        {
            if (!InRange(row, col))
            {
                return;
            }

            if (Matrix[row, col] != EmpyCellSymbol)
            { 
                return;
            }

            Matrix[row, col] = VisitedCellSymbol;
            area.Size++;

            TraverseUnvisitedArea(area, row, col + 1);
            TraverseUnvisitedArea(area, row + 1, col);
            TraverseUnvisitedArea(area, row, col - 1);
            TraverseUnvisitedArea(area, row - 1, col);
        }

        private static bool HasUnvisitedCell()
        {
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < Matrix.GetLength(1); col++)
                {
                    if (Matrix[row, col] == EmpyCellSymbol)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static void FindFirstUnvisitedArea(int[] coordinates)
        {
            for (int row = 0; row < Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < Matrix.GetLength(1); col++)
                {
                    if (Matrix[row, col] == EmpyCellSymbol)
                    {
                        coordinates[0] = row;
                        coordinates[1] = col;
                        return;
                    }
                }
            }
        }

        private static bool InRange(int row, int col)
        {
            bool rowInRange = 0 <= row && row < Matrix.GetLength(0);
            bool colInRange = 0 <= col && col < Matrix.GetLength(1);

            return rowInRange && colInRange;
        }
    }
}
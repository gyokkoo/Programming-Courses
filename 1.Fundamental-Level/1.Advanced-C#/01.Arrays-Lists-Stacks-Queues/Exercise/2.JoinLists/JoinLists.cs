namespace _2.JoinLists
{
    using System;
    using System.Collections.Generic;

    public class JoinLists
    {
        public static void Main()
        {
            SortedSet<int> joinedList = new SortedSet<int>();

            List<int> firstList = new List<int>();
            string[] firstInputLineArr = Console.ReadLine().Split(' ');
            for (int i = 0; i < firstInputLineArr.Length; i++)
            {
                firstList.Add(int.Parse((firstInputLineArr[i])));
                joinedList.Add(firstList[i]);
            }

            List<int> secondList = new List<int>();
            string[] secondInputLineArr = Console.ReadLine().Split(' ');
            for (int i = 0; i < secondInputLineArr.Length; i++)
            {
                secondList.Add(int.Parse((secondInputLineArr[i])));
                joinedList.Add(secondList[i]);
            }

            Console.WriteLine(string.Join(", ", joinedList));
        }
    }
}
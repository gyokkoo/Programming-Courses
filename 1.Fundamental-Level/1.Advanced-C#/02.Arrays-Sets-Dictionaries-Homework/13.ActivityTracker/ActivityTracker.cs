using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

/*
This problem is from the Java Basics Exam (3 September 2014). 
You may check your solution here.
https://judge.softuni.bg/Contests/Practice/Index/30#3
*/
class ActivityTracker
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

        int nLines = int.Parse(Console.ReadLine());

        var userData = new SortedDictionary<int, SortedDictionary<string, List<double>>>();

        for (int i = 0; i < nLines; i++)
        {
            string[] userInformartion = Console.ReadLine().Split(' ');

            int month = DateTime.Parse(userInformartion[0]).Month;
            string name = userInformartion[1];
            double distance = double.Parse(userInformartion[2]);

            if (!userData.ContainsKey(month))
            {
                var nameDistance = new SortedDictionary<string, List<double>>();
                var walkDistances = new List<double>();

                walkDistances.Add(distance);
                nameDistance.Add(name, walkDistances);
                userData.Add(month, nameDistance);
            }
            else if (userData.ContainsKey(month))
            {
                if (!userData[month].ContainsKey(name))
                {
                    var walkDistances = new List<double>();

                    walkDistances.Add(distance);

                    userData[month].Add(name, walkDistances);
                }
                else if (userData[month].ContainsKey(name))
                {
                    userData[month][name].Add(distance);
                }
            }
        }

        var results = new SortedDictionary<int, SortedSet<string>>();

        foreach (var month in userData)
        {
            SortedSet<string> usersDistances = new SortedSet<string>();

            foreach (var name in month.Value)
            {
                string userTotalDistances = name.Key + "(" + name.Value.Aggregate((a, b) => a + b) + ")";

                usersDistances.Add(userTotalDistances);
            }
            results.Add(month.Key, usersDistances);
        }

        foreach (var pair in results)
        {
            Console.WriteLine("{0}: {1}", pair.Key, string.Join(", ", pair.Value));
        }
    }
}
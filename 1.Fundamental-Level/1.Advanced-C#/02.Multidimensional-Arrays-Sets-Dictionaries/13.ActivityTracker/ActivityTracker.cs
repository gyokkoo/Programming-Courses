namespace _13.ActivityTracker
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public class ActivityTracker
    {
        public static void Main()
        {
            var activities = new SortedDictionary<int, SortedDictionary<string, double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] userData = Console.ReadLine().Split();
                int month = int.Parse(userData[0].Split('/')[1]);
                string name = userData[1];
                double distance = double.Parse(userData[2]);

                if (!activities.ContainsKey(month))
                {
                    activities[month] = new SortedDictionary<string, double>();
                    activities[month][name] = distance;
                }
                else
                {
                    if (!activities[month].ContainsKey(name))
                    {
                        activities[month][name] = distance;
                    }
                    else
                    {
                        distance += activities[month][name];
                        activities[month][name] = distance;
                    }
                }
            }

            foreach (var pair in activities)
            {
                Console.Write(pair.Key + ": ");
                List<string> result = new List<string>();
                foreach (var pair2 in pair.Value)
                {
                    result.Add(string.Format("{0}({1})", pair2.Key, pair2.Value));
                }

                Console.WriteLine(string.Join(", ", result));
            }
        }
    }
}

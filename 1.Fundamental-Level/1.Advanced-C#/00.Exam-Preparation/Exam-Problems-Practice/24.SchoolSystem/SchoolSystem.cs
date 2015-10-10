using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SchoolSystem
{
    static void Main()
    {
        int inputLines = int.Parse(Console.ReadLine());
        var dict = new SortedDictionary<string, SortedDictionary<string, List<double>>>();
        for (int i = 0; i < inputLines; i++)
        {
            string[] information = Console.ReadLine().Split();
            string fullName = information[0] + " " + information[1];
            string subject = information[2];
            double score = double.Parse(information[3]);

            if (dict.ContainsKey(fullName))
            {
                if (dict[fullName].ContainsKey(subject))
                {
                    dict[fullName][subject].Add(score);
                }
                else
                {
                    var scores = new List<double>();
                    scores.Add(score);
                    dict[fullName].Add(subject, scores);
                }
            }
            else
            {
                var scores = new List<double>();
                scores.Add(score);
                var subjects = new SortedDictionary<string, List<double>>();
                subjects.Add(subject, scores);
                dict.Add(fullName, subjects);
            }
        }

        foreach (var student in dict)
        {
            var result = new StringBuilder();
            result.Append(student.Key + ": [");
            foreach (var subject in student.Value)
            {
                result.Append(subject.Key + " - " + subject.Value.Average().ToString("0.00") + ", ");
            }
            result.Remove(result.Length - 2, 2);
            result.Append("]");
            Console.WriteLine(result);
        }
    }
}

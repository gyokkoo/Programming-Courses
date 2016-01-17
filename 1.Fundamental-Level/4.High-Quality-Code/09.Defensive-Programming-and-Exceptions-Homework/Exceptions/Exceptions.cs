namespace Exceptions_Homework
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Exceptions
    {
        public static void Main()
        {
            var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(string.Join(" ", subarr));

            var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(string.Join(" ", allarr));

            var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(string.Join(" ", emptyarr));

            Console.WriteLine(ExtractEnding("I love C#", 2));
            Console.WriteLine(ExtractEnding("Nakov", 4));
            Console.WriteLine(ExtractEnding("beer", 4));

            // Console.WriteLine(ExtractEnding("Hi", 100)); // will throw an exception
            Console.WriteLine(CheckPrime(23) ? "23 is prime." : "23 is not prime.");
            Console.WriteLine(CheckPrime(33) ? "33 is prime." : "33 is not prime.");

            List<Exam> peterExams = new List<Exam>()
                                        {
                                            new SimpleMathExam(2),
                                            new CSharpExam(55),
                                            new CSharpExam(100),
                                            new SimpleMathExam(1),
                                            new CSharpExam(0),
                                        };
            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }

        public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
        {
            if (startIndex < 0 || arr.Length <= startIndex)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex), "Start index must be in range 0 to arr.Length.");
            }

            if (count < 0 || arr.Length - startIndex < count)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "The count must be in range 0 to (arr.Length - startIndex).");
            }

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (count > str.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "The count must be less than str.Length.");
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        public static bool CheckPrime(int number)
        {
            for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
            {
                if (number % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

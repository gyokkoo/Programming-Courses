namespace _04.SequencesOfEqualStrings
{
    using System;
    using System.Collections.Generic;

    public class SequencesOfEqualStrings
    {
        public static void Main()
        {
            string[] lineStrings = Console.ReadLine().Split(' ');

            Console.Write(lineStrings[0] + " ");
            for (int i = 1; i < lineStrings.Length; i++)
            {
                string previousElement = lineStrings[i - 1];
                string currentElement = lineStrings[i];

                if (currentElement == previousElement)
                {
                    Console.Write(currentElement + " ");
                }
                else
                {
                    Console.Write("{0}{1} ", Environment.NewLine, currentElement);
                }
            }

            Console.WriteLine();
        }
    }
}
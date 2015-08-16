namespace BePositive
{
    using System;
    using System.Collections.Generic;

    public class BePositiveMain
    {
        public static void Main()
        {
            int countSequences = int.Parse(Console.ReadLine());

            for (int i = 0; i < countSequences; i++)
            {
                char[] whitespaces = { ' ' };
                string[] input = Console.ReadLine().Split(whitespaces, StringSplitOptions.RemoveEmptyEntries);
                var numbers = new List<int>();

                for (int j = 0; j < input.Length; j++)
                {
                    int num = int.Parse(input[j]);
                    numbers.Add(num);
                }

                bool found = false;

                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        if (found)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(currentNum);

                        found = true;
                    }
                    else
                    {
                        if (j < numbers.Count - 1)
                        {
                            currentNum += numbers[j + 1];
                        }
                        else
                        {
                            break;
                        }

                        if (currentNum >= 0)
                        {
                            if (found)
                            {
                                Console.Write(" ");
                            }

                            Console.Write(currentNum);
                            j++;
                            found = true;
                        }
                        else
                        {
                            j++;
                        }
                    }
                }


                if (!found)
                {
                    Console.WriteLine("(empty)");
                }
                else
                {
                    Console.WriteLine();
                }

                numbers.Clear();
            }
        }
    }
}
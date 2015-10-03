using System;
using System.IO;

/*
Write a program that reads a text file and prints on the console its odd lines. 
Line numbers starts from 0. Use StreamReader
 */
class OddLines
{
    static void Main()
    {
        Console.Title = "Problem 1.	Odd Lines";

        StreamReader reader = new StreamReader("../../text.txt");

        using (reader)
        {
            int lineNumber = 0;

            string line = reader.ReadLine();

            while (line != null)
            {
                lineNumber++;
                if (lineNumber%2 == 0)
                {
                    Console.WriteLine(line);
                }

                line = reader.ReadLine();
            }
        }
    }
}


using System;
using System.IO;

/*
Write a program that reads a text file and inserts line numbers in front of each of its lines. 
The result should be written to another text file. Use StreamReader in combination with StreamWriter.
 */

class LineNumbers
{
    static void Main()
    {
        Console.Title = "Problem 2.	Line Numbers";

        StreamReader reader = new StreamReader("../../InputFile.txt");
        StreamWriter writer = new StreamWriter("../../OutputFile.txt");

        using (reader) 
        {
            using (writer)
            {
                string line = reader.ReadLine();
                int lineNumber = 1;
                while (line != null)
                {
                    writer.WriteLine("Line number {0}: {1}", lineNumber, line);
                    Console.WriteLine("Line number {0}: {1}", lineNumber, line);

                    line = reader.ReadLine();
                    lineNumber++;
                }
            }
        }
    }
}

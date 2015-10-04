using System;
using System.Collections.Generic;
using System.IO;

/*
Write a program that takes any file and slices it to n parts. 
Write the following methods:
•	Slice(string sourceFile, string destinationDirectory, int parts) 
slices the given source file into n parts and saves them in destinationDirectory.
•	Assemble(List<string> files, string destinationDirectory)
combines all files into one, in the order they are passed, and saves the result in destinationDirectory. 

Use FileStreams. You are not allowed to use the File class or similar helper classes.
 */

class SlicingFile
{
    static List<string> files = new List<string>();

    static void Main() //решението не е мое
    {
        Console.Title = "Problem 5.	Slicing File";

        string sourcePath = "../../picture.jpg";
        string resultPath = "../../result";

        Directory.CreateDirectory(Path.GetDirectoryName(resultPath));

        Console.Write("n = ");
        int parts = int.Parse(Console.ReadLine());


        Slice(sourcePath, resultPath, parts);
        Assemble(files, sourcePath, resultPath);
    }

    private static void Slice(string sourcePath, string resultPath, int parts)
    {
        using (var source = new FileStream(sourcePath, FileMode.Open))
        {
            long a = source.Length;
            int sizeOfChunk = (int)Math.Ceiling((double)source.Length / parts);
            for (int i = 1; i <= parts; i++)
            {
                string path = string.Format("{0}-{1}", (resultPath + Path.GetFileNameWithoutExtension(sourcePath)),
                    (i + Path.GetExtension(sourcePath)));
                using (var result = new FileStream(path, FileMode.Create))
                {
                    files.Add(path);
                    while (result.Position < sizeOfChunk)
                    {
                        byte[] buffer;
                        if (sizeOfChunk > 4096)
                        {
                            buffer = new byte[4096];
                        }
                        else
                        {
                            buffer = new byte[sizeOfChunk];
                        }

                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        result.Write(buffer, 0, readBytes);

                        if (readBytes <= 0 || result.Position >= sizeOfChunk)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
    private static void Assemble(List<string> files, string sourcePath, string resultPath)
    {
        using (var result = new FileStream(resultPath + Path.GetFileName(sourcePath), FileMode.Create))
        {
            for (int i = 0; i < files.Count; i++)
            {
                using (var source = new FileStream(files[i], FileMode.Open))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }
                        result.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
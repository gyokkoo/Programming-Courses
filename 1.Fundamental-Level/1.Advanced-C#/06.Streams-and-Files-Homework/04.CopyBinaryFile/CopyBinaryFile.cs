using System;
using System.IO;
/*
Write a program that copies the contents of a binary file (e.g. image, video, etc.) to another using FileStream. 
You are not allowed to use the File class or similar helper classes.
 */

class CopyBinaryFile
{
    static void Main()
    {
        Console.Title = "Problem 4.	Copy Binary File";

        using (var source = new FileStream("../../picture.jpg.", FileMode.Open))
        {
            using (var destination = new FileStream("../../result.jpg", FileMode.Create))
            {
                double fileLength = source.Length;
                byte[] buffer = new byte[4096];
                while (true)
                {
                    int readBytes = source.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }

                    destination.Write(buffer, 0, readBytes);

                    Console.WriteLine("{0:P}", Math.Min(source.Position / fileLength, 1));
                }
            }
        }
    }
}

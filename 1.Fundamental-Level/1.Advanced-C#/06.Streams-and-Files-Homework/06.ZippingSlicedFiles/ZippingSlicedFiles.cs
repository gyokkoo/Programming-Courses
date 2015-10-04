using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

/*
Modify your previous program to also compress the bytes while slicing parts 
and decompress them when assembling them back to the original file. 
Use GzipStream.
Tip: When getting files from directory, make sure you only get files with .gz extension 
(there might be hidden files).
 */

class Program
{

    static void Main()//решението не е мое
    {
        Console.Title = "Problem 6.	Zipping Sliced Files";

        Console.Write("n = ");
        int parts = int.Parse(Console.ReadLine());

        string sourcePath = "../../picture.jpg";
        string resultPath = "../../";

        Slice(sourcePath, resultPath, parts);

        List<string> files = new List<string>();
        files.AddRange(Directory.GetFiles(resultPath, "*.gz").ToList());

        Assemble(files, resultPath + "\\assembled" + Path.GetExtension(sourcePath));
    }

    static void Slice(string sourceFile, string destinationDirectory, int parts)
    {
        byte[] buffer;
        using (FileStream inputStream = new FileStream(sourceFile, FileMode.Open))
        {
            int length = (int)inputStream.Length;
            buffer = new byte[length];
            int count;
            int sum = 0;

            while ((count = inputStream.Read(buffer, sum, length - sum)) > 0)
            {
                sum += count;
            }
        }

        int partSize = (int)Math.Ceiling((double)(buffer.Length / parts));
        int fileOffset = 0;
        string currPartPath = string.Empty;
        int sizeRemaining = buffer.Length;

        for (int i = 0; i < parts; i++)
        {
            currPartPath = destinationDirectory + "\\" + "part - " + i + ".gz";

            if (!File.Exists(currPartPath))
            {
                using (FileStream fsPart = new FileStream(currPartPath, FileMode.CreateNew))
                {
                    using (GZipStream zip = new GZipStream(fsPart, CompressionMode.Compress, false))
                    {
                        sizeRemaining = buffer.Length - (i * partSize);

                        if (sizeRemaining < partSize)
                        {
                            partSize = sizeRemaining;
                        }

                        zip.Write(buffer, fileOffset, partSize);
                        fileOffset += partSize;
                    }
                }
            }
        }
    }

    private static void Assemble(List<string> files, string destinationDirectory)
    {
        using (FileStream fsSource = new FileStream(destinationDirectory, FileMode.Append))
        {
            foreach (var file in files)
            {
                if (!file.Contains("part"))
                {
                    continue;
                }

                byte[] buffer;
                using (FileStream fsDest = new FileStream(file, FileMode.Open))
                {
                    using (GZipStream zip = new GZipStream(fsDest, CompressionMode.Decompress, false))
                    {
                        buffer = new byte[4096];
                        int count;
                        while (true)
                        {
                            count = zip.Read(buffer, 0, buffer.Length);
                            if (count > 0)
                            {
                                fsSource.Write(buffer, 0, count);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
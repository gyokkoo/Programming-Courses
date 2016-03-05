namespace _06.ZippingSlicedFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;

    public class ZippingSlicedFiles
    {
        private const string SourcePath = "../../music.mp3";
        private const string ResultPath = "../../";

        public static void Main()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(ResultPath));

            Console.Write("n = ");
            int parts = int.Parse(Console.ReadLine());

            Slice(parts);

            List<string> paths = new List<string>();
            paths.AddRange(Directory.GetFiles(ResultPath, "*gz").ToList());

            Assemble(paths);
        }

        private static void Assemble(List<string> paths)
        {
            string resultPath = ResultPath + "\\assembled" + Path.GetExtension(SourcePath);
            using (var stream = new FileStream(resultPath, FileMode.Append))
            {
                foreach (var path in paths)
                {
                    if (!path.Contains("part"))
                    {
                        continue;
                    }

                    byte[] buffer;
                    using (var destination = new FileStream(path, FileMode.Open))
                    {
                        using (var zipStream = new GZipStream(destination, CompressionMode.Decompress, false))
                        {
                            buffer = new byte[4096];
                            while (true)
                            {
                                int count = zipStream.Read(buffer, 0, buffer.Length);
                                if (count > 0)
                                {
                                    stream.Write(buffer, 0, count);
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

        private static void Slice(int parts)
        {
            byte[] buffer;
            using (FileStream inputStream = new FileStream(SourcePath, FileMode.Open))
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
            string currentPartPath = string.Empty;
            int sizeRemaining = buffer.Length;

            for (int i = 1; i <= parts; i++)
            {
                currentPartPath = ResultPath + "\\" + "part - " + i + ".gz";

                if (!File.Exists(currentPartPath))
                {
                    using (var fileStreamPart = new FileStream(currentPartPath, FileMode.CreateNew))
                    {
                        using (var zipStream = new GZipStream(fileStreamPart, CompressionMode.Compress, false))
                        {
                            sizeRemaining = buffer.Length - (i * partSize);
                            if (sizeRemaining < partSize)
                            {
                                partSize = sizeRemaining;
                            }

                            zipStream.Write(buffer, fileOffset, partSize);
                            fileOffset += partSize;
                        }
                    }
                }
            }
        }
    }
}
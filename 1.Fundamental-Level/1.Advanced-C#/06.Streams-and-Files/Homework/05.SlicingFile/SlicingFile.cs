namespace _05.SlicingFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class SlicingFile
    {
        private const string SourcePath = "../../music.mp3";
        private const string ResultPath = "../../result";
        private static readonly List<string> Paths = new List<string>();

        public static void Main()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(ResultPath));

            Console.Write("n = ");
            int parts = int.Parse(Console.ReadLine());

            Slice(parts);

            Assemble();
        }

        private static void Assemble()
        {
            using (var result = new FileStream(ResultPath + Path.GetFileName(SourcePath), FileMode.Create))
            {
                foreach (string path in Paths)
                {
                    using (var source = new FileStream(path, FileMode.Open))
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

        private static void Slice(int parts)
        {
            using (var source = new FileStream(SourcePath, FileMode.Open))
            {
                int sizeOfChunk = (int)Math.Ceiling((double)source.Length / parts);
                for (int i = 1; i <= parts; i++)
                {
                    string path = string.Format("{0}-part{1}", ResultPath, i + Path.GetExtension(SourcePath));

                    using (var result = new FileStream(path, FileMode.Create))
                    {
                        Paths.Add(path);
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
    }
}

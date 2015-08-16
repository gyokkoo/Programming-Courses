namespace Debugging_Substring
{
    using System;

    public class Substring_broken
    {
        public static void Main()
        {
            char[] text = Console.ReadLine().ToCharArray();
            int jump = int.Parse(Console.ReadLine());

            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'p')
                {
                    hasMatch = true;

                    int endIndex = jump + 1;

                    if (i + endIndex > text.Length - 1)
                    {
                        endIndex = text.Length - i;
                    }

                    string stringText = new string(text);
                    string matchedString = stringText.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += jump;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}

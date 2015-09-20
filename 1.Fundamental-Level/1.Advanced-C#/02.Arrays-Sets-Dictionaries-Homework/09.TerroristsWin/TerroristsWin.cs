using System;
using System.Linq;
using System.Text;

/*
This problem is from the Java Basics Exam (7 January 2015). 
You may check your solution here.
https://judge.softuni.bg/Contests/Practice/Index/57#1
 */
class TerroristsWin
{
    static void Main()
    {
        string text = Console.ReadLine();

        int bombsCount = text.Count(x => x == '|') / 2;
        char[] textChArray = text.ToCharArray();

        int startSearchingIndex = 0;
        for (int i = 0; i < bombsCount; i++)
        {
            int startBombIndex = text.IndexOf("|", startSearchingIndex);
            int endBombIndex = text.IndexOf("|", startBombIndex + 1);

            int bombSum = 0;
            for (int j = startBombIndex + 1; j < endBombIndex; j++)
            {
                bombSum += text[j];
            }
            int bombImpact = bombSum % 10;

            int startDestruction = startBombIndex - bombImpact;
            int endDestruction = endBombIndex + bombImpact;

            startDestruction = startDestruction > 0 ? startDestruction : 0;
            endDestruction = endDestruction < text.Length ? endDestruction : text.Length - 1;

            for (int j = startDestruction; j <= endDestruction; j++)
            {
                textChArray[j] = '.';
            }
            //BOOM!
            startSearchingIndex = endBombIndex + 1;
        }

        foreach (char symbol in textChArray)
        {
            Console.Write(symbol);
        }
        Console.WriteLine();

    }
}

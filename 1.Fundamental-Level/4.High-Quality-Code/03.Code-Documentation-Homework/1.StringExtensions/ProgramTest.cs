namespace _1.StringExtensions
{
    using System;
    using System.Linq;

    public class ProgramTest
    {
        public static void Main()
        {
            Console.WriteLine("This is string 123!".ToMd5Hash());
            Console.WriteLine("True".ToBoolean());
            Console.WriteLine("32767".ToShort());
            Console.WriteLine("2147483647".ToInteger());
            Console.WriteLine("9223372036854775807".ToLong());
            Console.WriteLine("02.05.2005 10:30:25".ToDateTime());
            Console.WriteLine("pesho".CapitalizeFirstLetter());
            Console.WriteLine("asdfghGosho Peshev!@#$".GetStringBetween("asdfgh", "!@#$"));
            Console.WriteLine("софтуни.bg".ConvertCyrillicToLatinLetters());
            Console.WriteLine("judge.softuni.бг".ConvertLatinToCyrillicKeyboard());
            Console.WriteLine("-пeшo&Зvqra_1234!@#%".ToValidUsername());
            Console.WriteLine(@"Code Documentation Homework.sln".ToValidLatinFileName());
            Console.WriteLine("String 123456789".GetFirstCharacters(10));
            Console.WriteLine("StringExtensions.cs".GetFileExtension());
            Console.WriteLine(" docx ".ToContentType());

            string str = "I am string";
            str.ToByteArray().ToList().ForEach(x => Console.Write(x + " "));
            Console.WriteLine();
        }
    }
}

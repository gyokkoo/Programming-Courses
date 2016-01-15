namespace Methods
{
    using System;

    public class MethodsMain
    {
        public static void Main()
        {
            Console.WriteLine(Calculations.CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(Formatting.NumberAsString(5));

            Console.WriteLine(Calculations.FindMax(5, -1, 3, 2, 14, 2, 3));

            Console.WriteLine(Formatting.FormatNumber(1.3, "f"));
            Console.WriteLine(Formatting.FormatNumber(0.75, "%"));
            Console.WriteLine(Formatting.FormatNumber(2.30, "r"));

            Console.WriteLine(Calculations.CalculateDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + Calculations.IsHorizontal(3, -1));
            Console.WriteLine("Vertical? " + Calculations.IsVertical(3, 2.5));

            Student peter = new Student
                                {
                                    FirstName = "Peter",
                                    LastName = "Ivanov",
                                    AdditionalInfo = "From Sofia, born at 17.03.1992"
                                };

            Student stella = new Student
                                 {
                                     FirstName = "Stella",
                                     LastName = "Markova",
                                     AdditionalInfo = "From Vidin, gamer, high results, born at 17.03.1992"
                                 };

            Console.WriteLine(
                "{0} older than {1} -> {2}", 
                peter.FirstName, 
                stella.FirstName, 
                peter.IsOlderThan(stella));
        }
    }
}
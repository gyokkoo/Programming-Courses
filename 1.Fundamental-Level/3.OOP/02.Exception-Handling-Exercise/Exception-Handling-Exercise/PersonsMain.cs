using System;

class PersonsMain
{
    static void Main()
    {
        Person sasho = new Person("Sasho", "Ivanov", 25);
        
        try
        {
            Person noName = new Person(string.Empty, "Goshev", 31);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Exception thrown: {0}", ex.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Exception thrown: {0}", ex.Message);
        }
    
        //try
        //{
        //    Person negativeAge = new Person("Kaloyan", "Ivanov", -4);
        //}
        //catch (ArgumentNullException ex)
        //{
        //    Console.WriteLine("Exception thrown: {0}", ex.Message);
        //}
        //catch (ArgumentOutOfRangeException ex)
        //{
        //    Console.WriteLine("Exception thrown: {0}", ex.Message);
        //}
    }
}


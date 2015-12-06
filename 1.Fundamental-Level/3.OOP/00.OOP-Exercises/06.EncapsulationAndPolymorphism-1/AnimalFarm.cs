using System;

public class AnimalFarm
{
    public static void Main()
    {
        Chicken mara = new Chicken("Mara", 3);
        Chicken chicki = new Chicken("Chicki", 9);

        Console.WriteLine(mara.ProductPerDay);
        Console.WriteLine(chicki.ProductPerDay);
    }
}


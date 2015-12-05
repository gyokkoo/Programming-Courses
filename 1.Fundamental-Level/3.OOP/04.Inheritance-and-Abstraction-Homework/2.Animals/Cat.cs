using System;

public class Cat : Animal
{
    public Cat(string name, int age, string gender, ConsoleColor furColor)
        : base(name, age, gender)
    {
        this.FurColor = furColor;
    }

    public ConsoleColor FurColor { get; set; }

    public override void ProduceSound()
    {
        Console.WriteLine("Myuaa, Myuaa, Myuaa, ....");
    }
}


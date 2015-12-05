using System;

public class Frog : Animal
{
    public Frog(string name, int age, string gender, bool isPoisonous)
        : base(name, age, gender)
    {
        this.IsPoisonous = isPoisonous;
    }

    public bool IsPoisonous { get; set; }

    public override void ProduceSound()
    {
        Console.WriteLine("Quak, Quak, Quak, ...");
    }
}


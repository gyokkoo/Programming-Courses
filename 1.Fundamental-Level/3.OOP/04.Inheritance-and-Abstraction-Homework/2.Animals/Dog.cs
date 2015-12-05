using System;

public class Dog : Animal
{
    public Dog(string name, int age, string gender, string breed)
        : base(name, age, gender)
    {
        this.Breed = breed;
    }

    public string Breed { get; set; }

    public override void ProduceSound()
    {
        Console.WriteLine("Bau bau bau ...");
    }
}


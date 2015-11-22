using DefiningClasses_Exercise;
using System;

class DefiningClasses
{
    static void Main(string[] args)
    {
        Dog unnamed = new Dog();
        Dog sharo = new Dog("Sharo", "Melez");
        Dog dogi = new Dog("Dogi", "Shepherd");

        Dog[] dogs = new Dog[3];
        dogs[0] = sharo;
        dogs[1] = dogi;
        dogs[2] = unnamed;

        foreach (Dog dog in dogs)
        {
            dog.Bark();
        }
    }
}

using System;

namespace DefiningClasses_Exercise
{
    public class Dog
    {
        public Dog()
            : this(null, null)
        {

        }

        public Dog(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public string Name { get; set; }

        public string Breed { get; set; }

        public void Bark()
        {
            Console.WriteLine(
                "{0} ({1}) said: Bauuuuuu!", 
                this.Name ?? "[unnamed dog]",
                this.Breed ?? "[unknown breed]");
        }
    }
}

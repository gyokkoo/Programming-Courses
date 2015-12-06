using System;

public class Chicken : Animal
{
    public Chicken(string name, int age)
        : base(name, age)
    {
    }

    public override Product ProduceProduct()
    {
        return new Product();
    }

    public override double GetHumanAge()
    {
        return this.Age * 11;
    }
}

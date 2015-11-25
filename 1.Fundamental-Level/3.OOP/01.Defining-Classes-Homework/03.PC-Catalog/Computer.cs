using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Computer
{
    private string name;
    private List<Component> components;

    public Computer(string name, params Component[] components)
    {
        this.Name = name;
        this.components = new List<Component>();
        this.AddComponents(components);
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be null or empty!", "name");
            }

            this.name = value;
        }
    }

    public IEnumerable<Component> Components
    {
        get
        {
            return this.components;
        }
    }

    public decimal Price()
    {
        decimal price = components.Sum(c => c.Price);
        return price;
    }

    private void AddComponents(params Component[] components)
    {
        if(components.Length == 0)
        {
            throw new ArgumentException("Every computer should have parameters!", "components.Length");
        }

        this.components.AddRange(components);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine(new string('=', 25));
        sb.AppendLine("PC name: " + this.Name);

        foreach (Component component in this.Components) 
        {
            sb.AppendFormat("{0} -> {1} BGN\n", component.Name, component.Price);
        }

        sb.AppendLine("TOTAL PRICE -> " + this.Price() + " BGN");

        return sb.ToString();
    }
}


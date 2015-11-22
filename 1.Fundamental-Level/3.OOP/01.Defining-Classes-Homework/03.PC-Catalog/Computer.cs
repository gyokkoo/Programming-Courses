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
                throw new ArgumentException("Name cannot be null or empty!");
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
            throw new ArgumentException("Every computer should have parameters!");
        }

        this.components.AddRange(components);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("PC name: " + this.Name);
        foreach (Component component in this.Components) 
        {
            sb.AppendFormat("{0} -> {1}\n", component.Name, component.Price);
        }
        sb.AppendLine("Total Price -> " + this.Price() + " BGN");
        sb.Append(new string('-', 45));
        return sb.ToString();
    }
}


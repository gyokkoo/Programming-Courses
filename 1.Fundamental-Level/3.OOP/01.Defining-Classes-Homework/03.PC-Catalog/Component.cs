using System;
using System.Text;

public class Component
{
    private string name;
    private string details;
    private decimal price;

    public Component(string name, decimal price)
        : this(name, null, price)
    {
    }

    public Component(string name, string details, decimal price)
    {
        this.Name = name;
        this.Details = details;
        this.Price = price;
    }

    public string Name
    {
        get
        {
            return this.name;
        }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The name cannot be null or empty!", "name");
            }

            this.name = value;
        }
    }

    public string Details
    {
        get
        {
            return this.details;
        }

        set
        {
            this.details = value;
        }
    }

    public decimal Price
    {
        get
        {
            return this.price;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price value cannot be negative!", "price");
            }

            this.price = value;
        }
    }
}
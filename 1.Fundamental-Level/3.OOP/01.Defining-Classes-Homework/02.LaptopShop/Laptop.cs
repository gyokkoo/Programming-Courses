using System;
using System.Text;

public class Laptop
{
    private string model;
    private decimal price;

    public Laptop(
        string model, string manufacturer, string processor, int ram, string graphicsCard, string hdd, string screen, Battery battery, decimal price)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.Price = price;
        this.GraphicsCard = graphicsCard;
        this.Hdd = hdd;
        this.Screen = screen;
        this.Price = price;
        this.Battery = battery;
    }

    public Laptop(string model, decimal price)
        : this(model, null, null, 0, null, null, null, null, price)
    {
    }

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The model cannot be null or empty!");
            }

            this.model = value;
        }
    }

    public string Manufacturer { get; set; }
    public string Processor { get; set; }
    public int Ram { get; set; }
    public string GraphicsCard { get; set; }
    public string Hdd { get; set; }
    public string Screen { get; set; }
    public Battery Battery { get; set; }

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
                throw new ArgumentException("The price cannot be negative!");
            }

            this.price = value;
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine(new string('-', 40));
        sb.AppendLine("Laptop description:");
        sb.AppendLine("Model -> " + this.Model);

        if(this.Manufacturer != null)
        {
            sb.AppendLine("Manufacturer -> " + this.Manufacturer);
        }

        if(this.Processor != null)
        {
            sb.AppendLine("Processor -> " + this.Processor);
        }

        if(this.Ram != 0)
        {
            sb.AppendLine("RAM -> " + this.Ram + "GB");
        }

        if(this.GraphicsCard != null)
        {
            sb.AppendLine("Graphics card -> " + this.GraphicsCard);
        }

        if(this.Hdd != null)
        {
            sb.AppendLine("HDD -> " + this.Hdd);
        }

        if(this.Screen != null)
        {
            sb.AppendLine("Screen -> " + this.Screen);
        }

        if(this.Battery != null)
        {
            sb.Append(this.Battery.ToString());
        }

        sb.AppendLine(String.Format("Price -> {0:F2} lv.", this.Price));
        sb.Append(new string('-', 40));
        return sb.ToString();
    }
}

using System;

public class Battery
{
    private string type;
    private double batteryLife;

    public Battery(string type, double batteryLife)
    {
        this.Type = type;
        this.BatteryLife = batteryLife;
    }

    public string Type {
        get
        {
            return this.type;
        }
        set
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Type cannot be empty!");
            }

            this.type = value;                   
        }
    }

    public double BatteryLife
    {
        get
        {
            return this.batteryLife;
        }
        set
        {
            if(value < 0)
            {
                throw new ArgumentException("The price cannot be negative!");
            }

            this.batteryLife = value;
        }
    }

    public override string ToString()
    {
        string result = String.Format(
            "Battery -> {0}\nBattery life -> {1}\n", 
            this.Type, this.BatteryLife);
        return result;
    }
}


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

    public string Type
    {
        get
        {
            return this.type;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("The type cannot be empty!", "type");
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
            if (value < 0)
            {
                throw new ArgumentException("The battery life cannot be negative!", "battery life");
            }

            this.batteryLife = value;
        }
    }

    public override string ToString()
    {
        string result = String.Format(
            "Battery -> {0}\nBattery life -> {1} hours\n",
            this.Type, this.BatteryLife);

        return result;
    }
}


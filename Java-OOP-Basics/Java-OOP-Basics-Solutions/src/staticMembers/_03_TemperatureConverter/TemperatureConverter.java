package staticMembers._03_TemperatureConverter;

public class TemperatureConverter {
    public static double getFahrenheitTemperature(int celsius) {
        return celsius * 9.0 / 5 + 32;
    }

    public static double getCelsiusTemperature(int fahrenheit) {
        return (fahrenheit - 32.0) * 5 / 9;
    }
}

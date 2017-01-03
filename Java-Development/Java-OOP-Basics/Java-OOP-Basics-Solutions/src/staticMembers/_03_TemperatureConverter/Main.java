package staticMembers._03_TemperatureConverter;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        while (true) {
            String[] tokens = reader.readLine().split(" ");
            if (tokens[0].equals("End")) {
                break;
            }

            int temperature = Integer.parseInt(tokens[0]);
            String unit = tokens[1];
            switch (unit) {
                case "Celsius":
                    double fahrenheit = TemperatureConverter.getFahrenheitTemperature(temperature);
                    System.out.printf("%.2f Fahrenheit%n", fahrenheit);
                    break;
                case "Fahrenheit":
                    double celsius = TemperatureConverter.getCelsiusTemperature(temperature);
                    System.out.printf("%.2f Celsius%n", celsius);
                    break;
            }
        }
    }
}

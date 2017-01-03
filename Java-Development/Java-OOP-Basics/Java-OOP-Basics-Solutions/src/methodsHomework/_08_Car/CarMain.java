package methodsHomework._08_Car;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class CarMain {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] carTokens = reader.readLine().split(" ");
        double carSpeed = Integer.parseInt(carTokens[0]);
        double fuel = Integer.parseInt(carTokens[1]);
        double fuelEconomy = Integer.parseInt(carTokens[2]);
        Car car = new Car(carSpeed, fuel, fuelEconomy);

        while (true) {
            String[] commandTokens = reader.readLine().split(" ");
            if (commandTokens[0].equals("END")) {
                break;
            }

            switch (commandTokens[0]) {
                case "Travel":
                    double distance = Double.parseDouble(commandTokens[1]);
                    car.travel(distance);
                    break;
                case "Refuel":
                    double liters = Double.parseDouble(commandTokens[1]);
                    car.refuel(liters);
                    break;
                case "Distance":
                    double carDistance = car.getDistance();
                    System.out.printf("Total distance: %.01f kilometers%n", carDistance);
                    break;
                case "Time":
                    double totalMinutes = car.getTravelTime();
                    System.out.printf("Total time: %.0f hours and %.0f minutes%n", totalMinutes / 60, totalMinutes % 60);
                    break;
                case "Fuel":
                    double remainingFuel = car.getFuelAmount();
                    System.out.printf("Fuel left: %.01f liters%n", remainingFuel);
                    break;
            }
        }
    }
}

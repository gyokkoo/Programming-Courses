package polymorphism._01_Vehicles;

import polymorphism._01_Vehicles.models.Car;
import polymorphism._01_Vehicles.models.Truck;
import polymorphism._01_Vehicles.models.Vehicle;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] carTokens = reader.readLine().split(" ");
        String[] truckTokens = reader.readLine().split(" ");
        Vehicle car = createVehicle(carTokens);
        Vehicle truck = createVehicle(truckTokens);

        int n = Integer.parseInt(reader.readLine());
        for (int i = 0; i < n; i++) {
            String[] commandTokens = reader.readLine().split(" ");
            String command = commandTokens[0];
            String vehicleType = commandTokens[1];
            switch (command) {
                case "Drive":
                    double distance = Double.parseDouble(commandTokens[2]);
                    String result = null;
                    if (vehicleType.equals("Car")) {
                        result = car.drive(distance);
                    } else if (vehicleType.equals("Truck")) {
                        result = truck.drive(distance);
                    }
                    System.out.println(result);
                    break;
                case "Refuel":
                    double litters = Double.parseDouble(commandTokens[2]);
                    if (vehicleType.equals("Car")) {
                        car.refuel(litters);
                    } else if (vehicleType.equals("Truck")) {
                        truck.refuel(litters);
                    }
                    break;
                default:
                    throw new IllegalArgumentException("Unknown command");
            }
        }

        System.out.println(car);
        System.out.println(truck);
    }

    private static Vehicle createVehicle(String[] tokens) {
        String vehicleType = tokens[0];
        double fuelQuantity = Double.parseDouble(tokens[1]);
        double fuelConsumption = Double.parseDouble(tokens[2]);
        switch (vehicleType) {
            case "Car":
                return new Car(fuelQuantity, fuelConsumption);
            case "Truck":
                return new Truck(fuelQuantity, fuelConsumption);
            default:
                throw new IllegalArgumentException("Unknown command");
        }
    }
}

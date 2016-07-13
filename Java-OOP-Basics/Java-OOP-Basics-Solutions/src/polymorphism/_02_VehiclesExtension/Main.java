package polymorphism._02_VehiclesExtension;

import polymorphism._02_VehiclesExtension.models.Bus;
import polymorphism._02_VehiclesExtension.models.Car;
import polymorphism._02_VehiclesExtension.models.Truck;
import polymorphism._02_VehiclesExtension.models.Vehicle;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.HashMap;
import java.util.LinkedHashMap;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String[] carTokens = reader.readLine().split(" ");
        String[] truckTokens = reader.readLine().split(" ");
        String[] busTokens = reader.readLine().split(" ");

        Vehicle car = createVehicle(carTokens);
        Vehicle truck = createVehicle(truckTokens);
        Vehicle bus = createVehicle(busTokens);

        HashMap<String, Vehicle> vehicles = new LinkedHashMap<>();
        vehicles.put("Car", car);
        vehicles.put("Truck", truck);
        vehicles.put("Bus", bus);

        int n = Integer.parseInt(reader.readLine());
        for (int i = 0; i < n; i++) {
            try {
                String[] commandTokens = reader.readLine().split(" ");
                String command = commandTokens[0];
                Vehicle vehicle = vehicles.get(commandTokens[1]);
                switch (command) {
                    case "Drive":
                        double distance = Double.parseDouble(commandTokens[2]);
                        System.out.println(vehicle.drive(distance));
                        break;
                    case "DriveEmpty":
                        double distanceToTravel = Double.parseDouble(commandTokens[2]);
                        Bus emptyBus = (Bus) vehicle;
                        System.out.println(emptyBus.driveEmptyBus(distanceToTravel));
                        break;
                    case "Refuel":
                        double litters = Double.parseDouble(commandTokens[2]);
                        vehicle.refuel(litters);
                        break;
                    default:
                        throw new IllegalArgumentException("Unknown command");
                }
            } catch (IllegalArgumentException e) {
                System.out.println(e.getMessage());
            }
        }

        vehicles.entrySet().stream().forEach(v -> System.out.println(v.getValue()));
    }

    private static Vehicle createVehicle(String[] tokens) {
        String vehicleType = tokens[0];
        double fuelQuantity = Double.parseDouble(tokens[1]);
        double fuelConsumption = Double.parseDouble(tokens[2]);
        double tankCapacity = Double.parseDouble(tokens[3]);
        switch (vehicleType) {
            case "Car":
                return new Car(fuelQuantity, fuelConsumption, tankCapacity);
            case "Truck":
                return new Truck(fuelQuantity, fuelConsumption, tankCapacity);
            case "Bus":
                return new Bus(fuelQuantity, fuelConsumption, tankCapacity);
            default:
                throw new IllegalArgumentException("Unknown command");
        }
    }
}

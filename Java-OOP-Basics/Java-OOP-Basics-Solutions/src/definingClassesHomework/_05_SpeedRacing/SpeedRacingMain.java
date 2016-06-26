package definingClassesHomework._05_SpeedRacing;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.LinkedHashMap;

public class SpeedRacingMain {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        LinkedHashMap<String, Car> carsByModel = new LinkedHashMap<>();
        int n = Integer.valueOf(reader.readLine());
        for (int i = 0; i < n; i++) {
            String[] params = reader.readLine().split(" ");
            String carModel = params[0];
            double fuelAmount = Double.valueOf(params[1]);
            double fuelCost = Double.valueOf(params[2]);
            Car car = new Car(carModel, fuelAmount, fuelCost);
            carsByModel.put(carModel, car);
        }

        while (true) {
            String[] tokens = reader.readLine().split(" ");
            if ("End".equals(tokens[0])) {
                break;
            }

            String carModel = tokens[1];
            double amountOfKm = Double.valueOf(tokens[2]);
            Car car = carsByModel.get(carModel);
            boolean isSufficientFuel = car.drive(amountOfKm);
            if (!isSufficientFuel) {
                System.out.println("Insufficient fuel for the drive");
            }
        }

        carsByModel.entrySet().forEach(car -> System.out.println(car.getValue()));
    }
}
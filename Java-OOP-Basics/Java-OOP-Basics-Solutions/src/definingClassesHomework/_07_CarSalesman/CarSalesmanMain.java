package definingClassesHomework._07_CarSalesman;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.HashMap;

public class CarSalesmanMain {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        HashMap<String, Engine> engines = new HashMap<>();
        int n = Integer.parseInt(reader.readLine());
        for (int i = 0; i < n; i++) {
            String[] engineArgs = reader.readLine().split(" ");
            String model = engineArgs[0];
            int power = Integer.parseInt(engineArgs[1]);
            Engine engine = null;
            if (engineArgs.length == 2) {
                engine = new Engine(model, power);
            } else if (engineArgs.length == 3) {
                if (isDigit(engineArgs[2])) {
                    int displacement = Integer.parseInt(engineArgs[2]);
                    engine = new Engine(model, power, displacement);
                } else {
                    String efficiency = engineArgs[2];
                    engine = new Engine(model, power, efficiency);
                }
            } else if (engineArgs.length == 4) {
                int displacement = Integer.parseInt(engineArgs[2]);
                String efficiency = engineArgs[3];
                engine = new Engine(model, power, displacement, efficiency);
            }

            engines.put(model, engine);
        }

        int m = Integer.parseInt(reader.readLine());
        for (int i = 0; i < m; i++) {
            String[] carArgs = reader.readLine().split(" ");
            String model = carArgs[0];
            Engine engine = engines.get(carArgs[1]);
            Car car = null;
            if (carArgs.length == 2) {
                car = new Car(model, engine);
            } else if (carArgs.length == 3) {
                if (isDigit(carArgs[2])) {
                    int weight = Integer.parseInt(carArgs[2]);
                    car = new Car(model, engine, weight);
                } else {
                    String color = carArgs[2];
                    car = new Car(model, engine, color);
                }
            } else if (carArgs.length == 4) {
                int weight = Integer.parseInt(carArgs[2]);
                String color = carArgs[3];
                car = new Car(model, engine, weight, color);
            }

            System.out.println(car);
        }
    }

    private static boolean isDigit(String str) {
        try {
            Integer.parseInt(str);
            return true;
        } catch (NumberFormatException e) {
            return false;
        }

    }
}

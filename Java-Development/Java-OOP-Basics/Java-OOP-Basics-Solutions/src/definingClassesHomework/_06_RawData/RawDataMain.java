package definingClassesHomework._06_RawData;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class RawDataMain {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        HashMap<String, List<Car>> carsByCargo = new HashMap<>();
        int n = Integer.valueOf(reader.readLine());
        for (int i = 0; i < n; i++) {
            String[] params = reader.readLine().split(" ");
            String model = params[0];
            int engineSpeed = Integer.valueOf(params[1]);
            int enginePower = Integer.valueOf(params[2]);
            int cargoWeight = Integer.valueOf(params[3]);
            String cargoType = params[4];
            double tire1Pressure = Double.valueOf(params[5]);
            int tire1Age = Integer.valueOf(params[6]);
            double tire2Pressure = Double.valueOf(params[7]);
            int tire2Age = Integer.valueOf(params[8]);
            double tire3Pressure = Double.valueOf(params[9]);
            int tire3Age = Integer.valueOf(params[10]);
            double tire4Pressure = Double.valueOf(params[11]);
            int tire4Age = Integer.valueOf(params[12]);

            Tire tire1 = new Tire(tire1Pressure, tire1Age);
            Tire tire2 = new Tire(tire2Pressure, tire2Age);
            Tire tire3 = new Tire(tire3Pressure, tire3Age);
            Tire tire4 = new Tire(tire4Pressure, tire4Age);
            List<Tire> tires = new ArrayList<>();
            tires.add(tire1);
            tires.add(tire2);
            tires.add(tire3);
            tires.add(tire4);

            Cargo cargo = new Cargo(cargoWeight, cargoType);
            Engine engine = new Engine(engineSpeed, enginePower);
            Car car = new Car(model, engine, cargo, tires);
            if (!carsByCargo.containsKey(cargoType)) {
                carsByCargo.put(cargoType, new ArrayList<>());
            }
            List<Car> cars = carsByCargo.get(cargoType);
            cars.add(car);
            carsByCargo.put(cargoType, cars);
        }

        String command = reader.readLine();
        List<Car> cars = carsByCargo.get(command);
        if ("fragile".equals(command)) {
            cars.stream()
                    .filter(car -> car.getTires()
                            .stream()
                            .anyMatch(tire -> tire.getPressure() < 1))
                    .forEach(System.out::println);
        } else if ("flamable".equals(command)) {
            cars.stream()
                    .filter(car -> car.getEngine().getEnginePower() > 250)
                    .forEach(System.out::println);
        }
    }
}
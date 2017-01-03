package interfacesAndAbstraction._06_BirthdayCelebrations;

import interfacesAndAbstraction._06_BirthdayCelebrations.interfaces.Birthable;
import interfacesAndAbstraction._06_BirthdayCelebrations.models.Citizen;
import interfacesAndAbstraction._06_BirthdayCelebrations.models.Pet;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        List<Birthable> birthables = new ArrayList<>();
        while (true) {
            String[] lineTokens = reader.readLine().split(" ");
            if (lineTokens[0].endsWith("End")) {
                break;
            }

            if (!lineTokens[0].equals("Robot")) {
                Birthable birthable = createBirthable(lineTokens);
                birthables.add(birthable);
            }
        }

        String birthYear = reader.readLine();
        List<Birthable> specificYearBirths = birthables
                .stream()
                .filter(birthable -> birthable.getBirthYear().equals(birthYear))
                .collect(Collectors.toList());


        if (!specificYearBirths.isEmpty()) {
            for (Birthable birthable : specificYearBirths) {
                System.out.println(birthable.getBirthdate());
            }
        }
    }

    private static Birthable createBirthable(String[] lineTokens) {
        switch (lineTokens[0]) {
            case "Citizen":
                String name = lineTokens[1];
                Integer age = Integer.valueOf(lineTokens[2]);
                String citizenId = lineTokens[3];
                String citizenBirthdate = lineTokens[4];
                return new Citizen(name, age, citizenId, citizenBirthdate);
            case "Pet":
                String petName = lineTokens[1];
                String petBirthdate = lineTokens[2];
                return new Pet(petName, petBirthdate);
            default:
                throw new IllegalArgumentException("Invalid input");
        }
    }
}

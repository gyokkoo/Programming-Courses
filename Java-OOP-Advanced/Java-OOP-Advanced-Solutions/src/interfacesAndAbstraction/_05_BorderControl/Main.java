package interfacesAndAbstraction._05_BorderControl;

import interfacesAndAbstraction._05_BorderControl.models.Citizen;
import interfacesAndAbstraction._05_BorderControl.models.Robot;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;
import java.util.stream.Collectors;

public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        List<Identifiable> identifiableList = new ArrayList<>();
        while (true) {
            String[] lineTokens = reader.readLine().split(" ");
            if (lineTokens[0].endsWith("End")) {
                break;
            }

            Identifiable rebel = createIdentifiable(lineTokens);
            identifiableList.add(rebel);
        }

        String fakeIds = reader.readLine();
        List<Identifiable> rebels = identifiableList
                .stream()
                .filter(rebel -> rebel.checkId(fakeIds))
                .collect(Collectors.toList());

        for (Identifiable rebel : rebels) {
            System.out.println(rebel.getId());
        }
    }

    private static Identifiable createIdentifiable(String[] lineTokens) {
        switch (lineTokens.length) {
            case 2:
                String model = lineTokens[0];
                String robotId = lineTokens[1];
                return new Robot(model, robotId);
            case 3:
                String name = lineTokens[0];
                Integer age = Integer.valueOf(lineTokens[1]);
                String citizenId = lineTokens[2];
                return new Citizen(name, age, citizenId);
            default:
                throw new IllegalArgumentException("Invalid input");
        }
    }
}

package interfacesAndAbstraction._07_FoodShortage;

import interfacesAndAbstraction._07_FoodShortage.interfaces.Buyer;
import interfacesAndAbstraction._07_FoodShortage.models.Citizen;
import interfacesAndAbstraction._07_FoodShortage.models.Rebel;

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Map<String, Buyer> buyers = new HashMap<>();
        int n = Integer.parseInt(scanner.nextLine());
        for (int i = 0; i < n; i++) {
            String[] lineArgs = scanner.nextLine().split(" ");
            Buyer buyer = createBuyer(lineArgs);

            buyers.put(lineArgs[0], buyer);
        }

        while (true) {
            String command = scanner.nextLine();
            if (command.equals("End")) {
                break;
            }

            if (buyers.containsKey(command)) {
                Buyer buyer = buyers.get(command);
                buyer.buyFood();
            }
        }

        Integer totalFood = buyers.entrySet()
                .stream()
                .mapToInt(buyer -> buyer.getValue().getFood())
                .sum();

        System.out.println(totalFood);
    }

    private static Buyer createBuyer(String[] lineArgs) {
        switch (lineArgs.length) {
            case 3:
                String rebelName = lineArgs[0];
                Integer rebelAge = Integer.valueOf(lineArgs[1]);
                String rebelGroup = lineArgs[2];

                return new Rebel(rebelName, rebelAge, rebelGroup);
            case 4:
                String citizenName = lineArgs[0];
                Integer citizenAge = Integer.valueOf(lineArgs[1]);
                String citizenId = lineArgs[2];
                String citizenBirthdate = lineArgs[3];

                return new Citizen(citizenName, citizenAge, citizenId, citizenBirthdate);
            default:
                throw new IllegalArgumentException("Invalid input");
        }
    }
}

package generics._11_Threeuple;

import generics._11_Threeuple.interfaces.Threeuple;
import generics._11_Threeuple.models.ThreeupleImpl;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] personTokens = scanner.nextLine().split(" ");
        String fullName = personTokens[0] + " " + personTokens[1];
        String address = personTokens[2];
        String town = personTokens[3];
        Threeuple<String, String, String> firstTuple = new ThreeupleImpl<>(fullName, address, town);
        System.out.println(firstTuple.toString());

        String[] beerTokens = scanner.nextLine().split(" ");
        String name = beerTokens[0];
        Integer amountOfBeer = Integer.valueOf(beerTokens[1]);
        Boolean isDrunk = beerTokens[2].equals("drunk");
        Threeuple<String, Integer, Boolean> secondTuple = new ThreeupleImpl<>(name, amountOfBeer, isDrunk);
        System.out.println(secondTuple.toString());

        String[] bankTokens = scanner.nextLine().split(" ");
        String clientName = bankTokens[0];
        Double accountBalance = Double.valueOf(bankTokens[1]);
        String bankName = bankTokens[2];
        Threeuple<String, Double, String> thirdTuple = new ThreeupleImpl<>(clientName, accountBalance, bankName);
        System.out.println(thirdTuple.toString());
    }
}
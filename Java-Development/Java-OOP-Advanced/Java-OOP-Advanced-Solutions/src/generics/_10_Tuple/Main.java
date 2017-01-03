package generics._10_Tuple;

import generics._10_Tuple.interfaces.Tuple;
import generics._10_Tuple.models.TupleImpl;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] personTokens = scanner.nextLine().split(" ");
        String fullName = personTokens[0] + " " + personTokens[1];
        String address = personTokens[2];
        Tuple<String, String> firstTuple = new TupleImpl<>(fullName, address);
        System.out.println(firstTuple);

        String[] personBeerTokens = scanner.nextLine().split(" ");
        String name = personBeerTokens[0];
        Integer amountOfBeer = Integer.valueOf(personBeerTokens[1]);
        Tuple<String, Integer> secondTuple = new TupleImpl<>(name, amountOfBeer);
        System.out.println(secondTuple);

        String[] numberTokens = scanner.nextLine().split(" ");
        Integer anInt = Integer.valueOf(numberTokens[0]);
        Double aDouble = Double.valueOf(numberTokens[1]);
        Tuple<Integer, Double> thirdTuple = new TupleImpl<>(anInt, aDouble);
        System.out.println(thirdTuple);
    }
}
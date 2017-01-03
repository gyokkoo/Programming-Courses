package enumerationAndAnnotations._02_CardRanks;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String enumName = scanner.nextLine();

        System.out.println(enumName + ":");
        for (CardRank cardRank : CardRank.values()) {
            System.out.printf("Ordinal value: %d; Name value: %s%n",
                    cardRank.ordinal(),
                    cardRank.name());
        }
    }
}
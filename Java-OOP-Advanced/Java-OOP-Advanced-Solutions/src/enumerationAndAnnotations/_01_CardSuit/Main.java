package enumerationAndAnnotations._01_CardSuit;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String enumName = scanner.nextLine();

        System.out.println(enumName + ":");
        for (CardSuit cardSuit : CardSuit.values()) {
            System.out.printf("Ordinal value: %d; Name value: %s%n",
                    cardSuit.ordinal(),
                    cardSuit.name());
        }
    }
}

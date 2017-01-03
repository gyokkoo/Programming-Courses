package enumerationAndAnnotations._06_CustomEnumAnnotation;

import enumerationAndAnnotations._06_CustomEnumAnnotation.enums.CardRank;
import enumerationAndAnnotations._06_CustomEnumAnnotation.enums.CardSuit;

import java.lang.annotation.Annotation;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String command = scanner.nextLine();

        Annotation[] annotations = null;
        switch (command) {
            case "Rank":
                annotations = CardRank.class.getAnnotations();
                break;
            case "Suit":
                annotations = CardSuit.class.getAnnotations();
        }

        for (Annotation annotation : annotations) {
            if (annotation instanceof CardEnumeration) {
                CardEnumeration cardEnumeration = (CardEnumeration) annotation;
                System.out.printf("Type = %s, Description = %s%n",
                        cardEnumeration.type(),
                        cardEnumeration.description());
            }
        }

    }
}

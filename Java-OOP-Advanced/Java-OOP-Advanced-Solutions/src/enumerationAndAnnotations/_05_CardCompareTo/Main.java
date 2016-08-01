package enumerationAndAnnotations._05_CardCompareTo;

import enumerationAndAnnotations._05_CardCompareTo.enums.CardRank;
import enumerationAndAnnotations._05_CardCompareTo.enums.CardSuit;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String firstRankOfCard = scanner.nextLine();
        String firstSuitOfCard = scanner.nextLine();
        CardRank firstCardRank = Enum.valueOf(CardRank.class, firstRankOfCard);
        CardSuit firstCardSuit = Enum.valueOf(CardSuit.class, firstSuitOfCard);
        Card firstCard = new Card(firstCardRank, firstCardSuit);

        String secondRankOfCard = scanner.nextLine();
        String secondSuitOfCard = scanner.nextLine();
        CardRank secondCardRank = Enum.valueOf(CardRank.class, secondRankOfCard);
        CardSuit secondCardSuit = Enum.valueOf(CardSuit.class, secondSuitOfCard);
        Card secondCard = new Card(secondCardRank, secondCardSuit);

        if (firstCard.compareTo(secondCard) > 1) {
            System.out.println(firstCard);
        } else {
            System.out.println(secondCard);
        }
    }
}
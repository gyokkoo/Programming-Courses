package enumerationAndAnnotations._04_CardToString;

import enumerationAndAnnotations._04_CardToString.enums.CardRank;
import enumerationAndAnnotations._04_CardToString.enums.CardSuit;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String rankOfCard = scanner.nextLine();
        String suitOfCard = scanner.nextLine();

        CardRank cardRank = Enum.valueOf(CardRank.class, rankOfCard);
        CardSuit cardSuit = Enum.valueOf(CardSuit.class, suitOfCard);

        Card card = new Card(cardRank, cardSuit);
        System.out.println(card.toString());
    }
}
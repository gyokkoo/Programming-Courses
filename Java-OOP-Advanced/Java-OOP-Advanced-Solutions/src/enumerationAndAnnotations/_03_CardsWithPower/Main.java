package enumerationAndAnnotations._03_CardsWithPower;

import enumerationAndAnnotations._03_CardsWithPower.enums.CardRank;
import enumerationAndAnnotations._03_CardsWithPower.enums.CardSuit;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String rankOfCard = scanner.nextLine();
        String suitOfCard = scanner.nextLine();

        CardRank cardRank = Enum.valueOf(CardRank.class, rankOfCard);
        CardSuit cardSuit = Enum.valueOf(CardSuit.class, suitOfCard);

        Card card = new Card(cardRank, cardSuit);
        System.out.printf("Card name: %s of %s; Card power: %d",
                card.getCardRank().name(),
                card.getCardSuit().name(),
                card.getCardPower());
    }
}
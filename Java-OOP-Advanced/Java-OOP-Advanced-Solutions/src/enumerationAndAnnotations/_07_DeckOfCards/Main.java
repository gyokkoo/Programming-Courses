package enumerationAndAnnotations._07_DeckOfCards;

import enumerationAndAnnotations._07_DeckOfCards.enums.CardRank;
import enumerationAndAnnotations._07_DeckOfCards.enums.CardSuit;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String command = scanner.nextLine();

        for (CardSuit cardSuit : CardSuit.values()) {
            for (CardRank cardRank : CardRank.values()) {
                Card card = new Card(cardRank, cardSuit);
                System.out.println(card);
            }
        }
    }
}

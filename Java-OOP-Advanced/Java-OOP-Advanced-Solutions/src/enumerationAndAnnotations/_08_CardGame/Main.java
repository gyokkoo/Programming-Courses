package enumerationAndAnnotations._08_CardGame;

import enumerationAndAnnotations._08_CardGame.enums.CardRank;
import enumerationAndAnnotations._08_CardGame.enums.CardSuit;
import enumerationAndAnnotations._08_CardGame.exceptions.NoSuchCardInDeckException;
import enumerationAndAnnotations._08_CardGame.models.Card;
import enumerationAndAnnotations._08_CardGame.models.CardDeck;
import enumerationAndAnnotations._08_CardGame.models.Player;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        CardDeck cardDeck = new CardDeck(CardRank.values(), CardSuit.values());

        String firstPlayerName = scanner.nextLine();
        String secondPlayerName = scanner.nextLine();

        Player firstPlayer = new Player(firstPlayerName);
        Player secondPlayer = new Player(secondPlayerName);

        addCardsToPlayer(scanner, cardDeck, firstPlayer);
        addCardsToPlayer(scanner, cardDeck, secondPlayer);

        if (firstPlayer.getBiggestCard().compareTo(secondPlayer.getBiggestCard()) > 0) {
            System.out.println(firstPlayer);
        } else {
            System.out.println(secondPlayer);
        }
    }

    private static void addCardsToPlayer(Scanner scanner, CardDeck cardDeck, Player player) {
        while (player.getCardsCount() < 5) {
            String[] cardTokens = scanner.nextLine().split("[\\s]+");
            try {
                tryAddCard(player, cardDeck, cardTokens);
            } catch (IllegalArgumentException iae) {
                System.out.println("No such card exists.");
            } catch (NoSuchCardInDeckException cardExc) {
                System.out.println(cardExc.getMessage());
            }
        }
    }

    private static void tryAddCard(Player player, CardDeck cardDeck, String[] cardTokens) {
        CardRank cardRank = CardRank.valueOf(cardTokens[0]);
        CardSuit cardSuit = CardSuit.valueOf(cardTokens[2]);
        Card card = new Card(cardRank, cardSuit);
        if (cardDeck.contains(card)) {
            player.addCard(card);
        }

        cardDeck.remove(card);
    }
}
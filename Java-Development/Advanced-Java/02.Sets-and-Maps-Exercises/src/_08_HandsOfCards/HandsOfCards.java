package _08_HandsOfCards;

import java.util.*;

public class HandsOfCards {
    private static final List<Character> POWERS = Arrays.asList('2', '3', '4', '5', '6', '7', '8', '9', '1', 'J', 'Q', 'K', 'A');
    private static final List<Character> SUITS = Arrays.asList('C', 'D', 'H', 'S');
    private static final String END_MESSAGE = "JOKER";

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        LinkedHashMap<String, HashSet<String>> handsOfCards = new LinkedHashMap<>();

        while (true) {
            String line = scanner.nextLine();
            if (line.equals(END_MESSAGE)) {
                break;
            }

            String[] lineArgs = line.split(":");
            String playerName = lineArgs[0];
            String[] playerCards = lineArgs[1].trim().split(", ");

            if (!handsOfCards.containsKey(playerName)) {
                handsOfCards.put(playerName, new HashSet<>());
            }

            HashSet<String> cardsSet = handsOfCards.get(playerName);
            Arrays.stream(playerCards).forEach(cardsSet::add);

            handsOfCards.put(playerName, cardsSet);
        }

        for (String name : handsOfCards.keySet()) {
            HashSet<String> playerCards = handsOfCards.get(name);
            int handSize = 0;
            for (String card : playerCards) {
                int power = POWERS.indexOf(card.charAt(0)) + 2;
                int suit = SUITS.indexOf(card.charAt(card.length() - 1)) + 1;
                handSize += power * suit;
            }
            System.out.printf("%s: %d%n", name, handSize);
        }
    }
}
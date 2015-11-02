import java.util.*;

public class _4_StraightFlush {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] cards = scanner.nextLine().split("\\W+");

        HashSet<String> existingCards = new HashSet<>();
        existingCards.addAll(Arrays.asList(cards));

        boolean isFound = false;
        for (int i = 0; i < cards.length; i++) {
            String cardFace = cards[i].substring(0, cards[i].length() - 1);
            String cardSuit = cards[i].substring(cards[i].length() - 1);

            ArrayList<String> straightFlush = new ArrayList<>();
            for (int j = 0; j < 5; j++) {
                straightFlush.add(cardFace + cardSuit);
                cardFace = GetNextCard(cardFace);
            }

            if (existingCards.containsAll(straightFlush)) {
                System.out.println(straightFlush);
                isFound = true;
            }
        }

        if (!isFound) {
            System.out.println("No Straight Flushes");
        }

    }

    public static String GetNextCard(String cardFace) {
        String[] cardFaces = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        for (int i = 1; i < cardFaces.length; i++) {
            if (cardFaces[i-1].equals(cardFace)) {
                return cardFaces[i];
            }
        }
        return null;
    }
}

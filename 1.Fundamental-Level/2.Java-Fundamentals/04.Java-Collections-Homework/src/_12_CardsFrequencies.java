import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class _12_CardsFrequencies {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a sequence of playing cards from a standard deck.");
        String[] cards = scanner.nextLine().split(" ");

        Map<String, Integer> cardsDictionary = new LinkedHashMap<>();

        for (String card : cards) {
            String face = card.substring(0, card.length() - 1);
            if(!cardsDictionary.containsKey(face)) {
                cardsDictionary.put(face, 0);
            }
            cardsDictionary.put(face, cardsDictionary.get(face) + 1);
        }

        for (Map.Entry<String, Integer> pair : cardsDictionary.entrySet()) {
            String cardFace = pair.getKey();
            double frequencies = pair.getValue() / (double)cards.length;
            System.out.printf("%s -> %.2f%%\n", cardFace, frequencies);
        }
    }
}

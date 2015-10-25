import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class _11_MostFrequentWord {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter some text in a single line.");
        String[] words = scanner.nextLine().toLowerCase().split("\\W+");

        int mostFrequentCount = 0;
        TreeMap<String, Integer> dictionary = new TreeMap();
        for (String word : words) {
            if (!dictionary.containsKey(word)) {
                dictionary.put(word, 0);
            }

            dictionary.put(word, dictionary.get(word) + 1);
            if (dictionary.get(word) > mostFrequentCount) {
                mostFrequentCount = dictionary.get(word);
            }
        }

        for (Map.Entry<String, Integer> word : dictionary.entrySet()) {
            if(word.getValue() == mostFrequentCount) {
                System.out.println(word.getKey() + " -> " + word.getValue());
            }
        }
    }
}

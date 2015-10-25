import java.util.Scanner;

public class _07_CountSubstring {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter some text on a single line and target string on the next line.");
        String words = scanner.nextLine().toLowerCase();
        String targetString = scanner.nextLine().toLowerCase();

        int occurrenceCounter = 0;
        for (int i = 0; i <= words.length() - targetString.length(); i++) {
            if(words.substring(i, i + targetString.length()).contains(targetString)) {
                occurrenceCounter++;
            }
        }
        System.out.println(occurrenceCounter);
    }
}

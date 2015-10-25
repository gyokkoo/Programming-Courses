import java.util.Scanner;

public class _06_CountSpecifiedWords {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter some text on a single line and target word on the next line.");
        String[] words = scanner.nextLine().toLowerCase().split("\\W+");
        String targetWord = scanner.nextLine().toLowerCase();

        int wordCounter = 0;
        for (String word : words) {
            if(word.equals(targetWord)) {
                wordCounter++;
            }
        }

        System.out.println(wordCounter);
    }
}

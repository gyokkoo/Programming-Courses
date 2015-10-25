import java.util.Scanner;

public class _05_CountAllWords {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter some text in a one line.");
        String[] words = scanner.nextLine().split("\\W+");

        System.out.println(words.length);
    }
}

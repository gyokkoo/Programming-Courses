import java.util.Scanner;
import java.util.stream.Stream;

public class _10_ExtractUniqueWords {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter some text on a single line.");
        String[] words = scanner.nextLine().toLowerCase().split("[^a-zA-Z]+");

        Stream.of(words).distinct().sorted().forEach(word -> System.out.print(word + " "));
    }
}

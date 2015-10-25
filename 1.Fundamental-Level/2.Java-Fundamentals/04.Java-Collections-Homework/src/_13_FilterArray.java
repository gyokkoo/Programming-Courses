import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class _13_FilterArray {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter some text on a single line.");
        String[] arrayOfStrings = scanner.nextLine().split(" ");
        Arrays.stream(arrayOfStrings)
                .filter(word -> word.length() > 3)
                .collect(Collectors.toList())
                .forEach(word -> System.out.print(word + " "));

    }
}

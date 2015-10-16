import java.util.Scanner;

public class _08_OddEvenPairs {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter an array of numbers in a single line.");
        String[] lineNumbers = scanner.nextLine().split(" ");

        int[] numbers = new int[lineNumbers.length];
        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = Integer.parseInt(lineNumbers[i]);
        }

        for (int i = 0; i < numbers.length; i++) {
            System.out.println(numbers[i]);
        }
    }
}

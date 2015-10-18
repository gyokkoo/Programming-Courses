import java.util.Scanner;

public class _06_FiveNumbersSum {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter five numbers.");
        int sum = 0;
        for (int i = 0; i < 5; i++) {
            int number = scanner.nextInt();
            sum += number;
        }

        System.out.println("The sum is " + sum);
    }
}

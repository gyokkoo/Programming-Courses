import java.util.Scanner;

public class _04_NumbersInRange {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter two numbers.");
        int firstNumber = scanner.nextInt();
        int secondNumber = scanner.nextInt();

        int min = Math.min(firstNumber, secondNumber);
        int max = Math.max(firstNumber, secondNumber);

        int count = 0;
        for (int i = min; i <= max; i++) {
            if(i % 5 == 0) {
                System.out.print(i + " ");
                count++;
            }
        }

        System.out.println("\nThe count is: " + count);
    }
}

import java.util.Scanner;

public class _05_CompareNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter two numbers.");
        int firstNumber = scanner.nextInt();
        int secondNumber = scanner.nextInt();

        int greater = (firstNumber + secondNumber + Math.abs(firstNumber - secondNumber)) / 2;

        System.out.println("The greater is: " + greater);
    }
}

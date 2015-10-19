import java.util.Scanner;

public class _01_ExchangeValues {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter two numbers.");
        int firstNumber = scanner.nextInt();
        int secondNumber = scanner.nextInt();

        if(firstNumber > secondNumber) {
            int exchangeValue = firstNumber;
            firstNumber = secondNumber;
            secondNumber = exchangeValue;
        }

        System.out.println(firstNumber + " " + secondNumber);
    }
}

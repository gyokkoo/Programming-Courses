import java.util.Scanner;

public class _03_CheckDigits {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a number.");
        int number = scanner.nextInt();
        boolean isThirdDigitSeven = number % 10 == 7;

        System.out.println("Is third digit seven ? -> " + isThirdDigitSeven);
    }
}
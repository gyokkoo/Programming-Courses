import java.util.Scanner;

public class _10_FourDigitNumber {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter four digit number.");
        int number = scanner.nextInt();
        int a = number / 1000;
        int b = number / 100 % 10;
        int c = number / 10 % 10;
        int d = number % 10;

        System.out.println("Digit sum is " + (a + b + c + d));
        System.out.println("The number in reversed orders is: " + (d*1000 + c*100 + b*10 + a));
        System.out.println("First and last digit swapped: " + (d*1000 + b*100 + c*10 + a));
        System.out.println("Second and third digit swapped: " + (a*1000 + c*100 + b*10 + d));
    }
}
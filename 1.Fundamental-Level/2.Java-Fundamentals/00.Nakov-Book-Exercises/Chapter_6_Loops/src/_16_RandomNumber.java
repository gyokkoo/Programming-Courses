import java.util.Scanner;

public class _16_RandomNumber {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a number.");
        System.out.print("N = ");
        int n = scanner.nextInt();

        int randomNumber = 1 + (int)(Math.random() * n);
        System.out.println("A random number between 1 and N -> " + randomNumber);
    }
}

import java.util.Scanner;

public class _05_PrintCharacterTriangle {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter a number.");
        int number = scanner.nextInt();
        //The english alphabet has 26 letters.

        printUpperTriangle(number);
        printDownTriangle(number);
    }

    private static void printUpperTriangle(int n) {
        for(int i = 1; i <= n - 1; i++) {
            for (int j = 0; j < i; j++) {
                char currentLetter = (char)('a' + j);
                System.out.print(currentLetter + " ");
            }
            System.out.println();
        }
    }

    private static void printDownTriangle(int n) {
        for (int i = n; i >= 0; i--) {
            for (int j = 0; j < i; j++) {
                char currentLetter = (char) ('a' + j);
                System.out.print(currentLetter + " ");
            }
            System.out.println();
        }
    }
}

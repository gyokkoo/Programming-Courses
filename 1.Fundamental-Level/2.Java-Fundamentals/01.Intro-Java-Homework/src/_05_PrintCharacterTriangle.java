import java.util.Scanner;

public class _05_PrintCharacterTriangle {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("n = ");
        int number = scanner.nextInt();
        //The english alphabet has only 26 letters.

        printUpperTriangle(number);
        printDownTriangle(number);
    }

    private static void printUpperTriangle(int n) {
        for(int i = 1; i <= n - 1; i++) {
            char c = 'a';
            for (int j = 0; j < i; j++) {
                c = (char)('a' + j);
                System.out.print(c + " ");
            }
            System.out.println();
        }
    }

    private static void printDownTriangle(int n) {
        for (int i = n; i >= 0; i--) {
            char c = 'a';
            for (int j = 0; j < i; j++) {
                c = (char) ('a' + j);
                System.out.print(c + " ");
            }
            System.out.println();
        }
    }

}

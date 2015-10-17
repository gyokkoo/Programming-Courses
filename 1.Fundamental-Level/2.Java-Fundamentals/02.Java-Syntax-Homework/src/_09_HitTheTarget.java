import java.util.Scanner;

public class _09_HitTheTarget {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a number.");
        int number = scanner.nextInt();

        for (int i = 1; i <= 20; i++) {
            for (int j = 1; j <= 20; j++) {
                if(i + j == number) {
                    System.out.println(String.format("%d + %d = %d", i, j, number));
                } else if(i - j == number) {
                    System.out.println(String.format("%d - %d = %d", i, j, number));
                }
            }
        }
    }
}

import java.util.Scanner;

public class _01_PrintNNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("N = ");
        int n = scanner.nextInt();

        for (int i = 1; i <= n; i++) {
            System.out.print(i + " ");
        }
    }
}

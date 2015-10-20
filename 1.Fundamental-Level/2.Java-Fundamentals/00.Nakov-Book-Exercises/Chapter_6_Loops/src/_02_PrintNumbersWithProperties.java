import java.util.Scanner;

public class _02_PrintNumbersWithProperties {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter N = ");
        int n = scanner.nextInt();

        for (int i = 1; i <= n; i++) {
            if(i % 3 == 0 || i % 7 == 0) {
                continue;
            }
            System.out.print(i + " ");
        }
    }
}

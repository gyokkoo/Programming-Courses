import java.util.Scanner;

public class _06_NKFactorial {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter N and K. 1<K<N");
        System.out.print("N = ");
        int n = scanner.nextInt();
        System.out.print("K = ");
        int k = scanner.nextInt();

        long result = 1;
        for (int i = k + 1; i <= n; i++) {
            result *= i;
        }

        System.out.println("N!/K! = " + result);
    }
}

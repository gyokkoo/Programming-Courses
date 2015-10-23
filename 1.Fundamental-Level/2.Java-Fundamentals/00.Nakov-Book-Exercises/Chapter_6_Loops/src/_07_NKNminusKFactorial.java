import java.util.Scanner;

public class _07_NKNminusKFactorial {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter N and K. 1<K<N");
        System.out.print("N = ");
        int n = scanner.nextInt();
        System.out.print("K = ");
        int k = scanner.nextInt();

        long nFactorial = 1;
        for (int i = 1; i <= n; i++) {
            nFactorial *= i;
        }

        long kFactorial = 1;
        for (int i = 1; i <= k; i++) {
            kFactorial *= i;
        }

        long nMinusKFactorial = 1;
        for (int i = 1; i <= n - k; i++) {
            nMinusKFactorial *= i;
        }
        System.out.println("N!*K!/(N-K)! = " + (nFactorial * kFactorial)/(nMinusKFactorial));
    }
}

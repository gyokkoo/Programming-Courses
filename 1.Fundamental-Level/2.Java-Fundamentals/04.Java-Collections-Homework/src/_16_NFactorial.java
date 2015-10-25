import java.util.Scanner;
//https://www.youtube.com/watch?v=fpuWkZs51aM

public class _16_NFactorial {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("N = ");
        int n = scanner.nextInt();

        long nFactorial = calculateFactorial(n);

        System.out.print("N! = " + nFactorial);
    }

    private static long calculateFactorial(long n) {
        if(n <= 1) {
            return 1;
        } else {
            return n * calculateFactorial(n -1);
        }
    }
}

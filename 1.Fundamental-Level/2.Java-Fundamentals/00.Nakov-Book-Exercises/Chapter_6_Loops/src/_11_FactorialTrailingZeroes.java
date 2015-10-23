import java.util.Scanner;

public class _11_FactorialTrailingZeroes {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("N = ");
        int n = scanner.nextInt();

        long nFactorial = 1;
        int zeroCounter = 0;
        for (int i = 1; i <= n; i++) {
            nFactorial *= i;
            if(nFactorial % 10 == 0) {
                zeroCounter++;
                nFactorial /= 10;
            }
        }

        System.out.println("N! has " + zeroCounter + " zeroes.");
    }
}

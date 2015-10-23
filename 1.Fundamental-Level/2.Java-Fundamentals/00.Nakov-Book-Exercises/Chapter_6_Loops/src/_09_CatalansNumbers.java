import java.util.Scanner;

public class _09_CatalansNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("n = ");
        int n = scanner. nextInt();

        double factorialN = 1;
        double factorial2N = 1;
        double factorialNplus1 = 1;

        for (int i = 1; i <= 2*n; i++) {
            factorial2N *= i;
            if(i <= n) {
                factorialN *= i;
            }
            if(i <= n + 1) {
                factorialNplus1 *= i;
            }
        }

        System.out.println("Cn = " + factorial2N / (factorialNplus1 * factorialN));
    }
}

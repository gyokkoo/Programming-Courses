import java.util.Scanner;

public class _08_SumS {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("N = ");
        int n = scanner.nextInt();
        System.out.print("x = ");
        int x = scanner.nextInt();

        double sum = 1;
        double factorial = 1;
        int power = x;
        for (int i = 1; i <= n ; i++) {
            factorial *= i;
            sum += factorial / x;
            x *= power;
        }

        System.out.println("S = " + sum);
    }
}

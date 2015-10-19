import java.util.Scanner;

public class _05_QuatricEquation {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a b and c coefficients");
        int a = scanner.nextInt();
        int b = scanner.nextInt();
        int c = scanner.nextInt();

        double discriminant = Math.sqrt(b*b - 4 * a * c);
        if(discriminant > 0) {
            double x1 = (-b + discriminant) / (2 * a);
            double x2 = (-b - discriminant) / (2 * a);
            System.out.println("x1 = " + x1);
            System.out.println("x2 = " + x2);
        }
        else if(discriminant == 0) {
            double x = (-b) / (2 * a);
            System.out.println("x = " + x);
        }
        else {
            System.out.println("No roots found!");
        }
    }
}

import java.util.Scanner;

public class _08_GetAverage {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double a = scanner.nextDouble();
        double b = scanner.nextDouble();
        double c = scanner.nextDouble();

        double average = getAverage(a,b,c);

        System.out.println(String.format("%.2f", average));
    }

    public static double getAverage(double a, double b, double c) {
        double average = (a + b + c)/3.0;

        return average;
    }
}

import java.util.Scanner;

public class _04_CalculateExpression {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter three floating-point numbers:");
        double a = scanner.nextDouble();
        double b = scanner.nextDouble();
        double c = scanner.nextDouble();

        double firstFormulae = Math.pow((a*a + b*b) / (a*a - b*b),(a+b+c)/Math.sqrt(c));
        double secondFormulae = Math.pow((a*a + b*b - c*c*c), (a-b));
        double numbersAverage = (a+b+c) / 3;
        double formulaeAverage = (firstFormulae + secondFormulae) / 2;

        System.out.format("F1 result: %.2f; ", firstFormulae);
        System.out.format("F2 result: %.2f; ", secondFormulae);
        System.out.format("Diff: %.2f", Math.abs(numbersAverage - formulaeAverage));
    }
}
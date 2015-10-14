import java.util.Scanner;

public class _08_GetAverage {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        double firstNumber = scanner.nextDouble();
        double secondNumber = scanner.nextDouble();
        double thirdNumber = scanner.nextDouble();

        double average = getAverage(firstNumber, secondNumber, thirdNumber);

        System.out.println(String.format("%.2f", average));
    }

    public static double getAverage(double firstNumber, double secondNumber, double thirdNumber) {
        double average = (firstNumber + secondNumber + thirdNumber)/3.0;

        return average;
    }
}

import java.util.Scanner;

public class _01_IntSum {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter three integer numbers.");
        int firstNum = scanner.nextInt();
        int secondNum = scanner.nextInt();
        int thirdNum = scanner.nextInt();

        int sum = firstNum + secondNum + thirdNum;
        System.out.printf("%d + %d + %d = %d", firstNum, secondNum, thirdNum, sum);
    }
}

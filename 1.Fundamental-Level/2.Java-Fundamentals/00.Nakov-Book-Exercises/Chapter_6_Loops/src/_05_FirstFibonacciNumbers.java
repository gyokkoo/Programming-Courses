import java.util.Scanner;

public class _05_FirstFibonacciNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("N = ");
        int n = scanner.nextInt();

        printFirstNFibonacciNumbers(n);
    }

    private static void printFirstNFibonacciNumbers(int n) {
        int firstNum = 1;
        int secondNum = 1;
        for (int i = 0; i < n; i++) {
            int thirdNum = firstNum + secondNum;
            firstNum = secondNum;
            secondNum = thirdNum;
            System.out.print(thirdNum + " ");
        }
    }
}

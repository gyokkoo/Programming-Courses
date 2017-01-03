package _08_RecursiveFibonacci;

import java.util.Scanner;

public class RecursiveFibonacci {

    private static final int MAX_FIBONACCI_NUMBER = 50;
    private static final long[] fib = new long[MAX_FIBONACCI_NUMBER];

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int nthFibonacci = scanner.nextInt();
        System.out.println(getFibonacci(nthFibonacci));
    }

    private static long getFibonacci(int number) {
        if (fib[number] == 0) {
            if ((number == 0 || number == 1)) {
                fib[number] = 1;
            } else {
                fib[number] = getFibonacci(number - 1) + getFibonacci(number - 2);
            }
        }

        return fib[number];
    }
}

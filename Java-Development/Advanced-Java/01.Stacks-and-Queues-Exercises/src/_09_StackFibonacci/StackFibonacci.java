package _09_StackFibonacci;

import java.util.Scanner;
import java.util.Stack;

public class StackFibonacci {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int nthFibonacci = scanner.nextInt();

        Stack<Long> fibonacciNumbers = new Stack<>();
        fibonacciNumbers.push(1L);
        fibonacciNumbers.push(1L);

        for (int i = 0; i < nthFibonacci - 1; i++) {
            long firstPreviousNumber = fibonacciNumbers.pop();
            long secondPreviousNumber = fibonacciNumbers.peek();

            fibonacciNumbers.push(firstPreviousNumber);
            long nextNumber = firstPreviousNumber + secondPreviousNumber;
            fibonacciNumbers.push(nextNumber);
        }

        System.out.println(fibonacciNumbers.peek());
    }
}

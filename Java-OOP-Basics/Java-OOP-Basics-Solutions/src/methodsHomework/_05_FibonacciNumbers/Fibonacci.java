package methodsHomework._05_FibonacciNumbers;

import java.util.ArrayList;

public class Fibonacci {
    private ArrayList<Long> numbers;

    public Fibonacci(int n) {
        this.numbers = new ArrayList<>();
        this.numbers.add(0L);
        this.numbers.add(1L);
        this.generateFibonacci(n);
    }

    public ArrayList<Long> getNumbersInRange(int startPosition, int endPosition) {
        ArrayList<Long> numbersInRange = new ArrayList<>();
        for (int i = startPosition; i < endPosition; i++) {
            numbersInRange.add(this.numbers.get(i));
        }

        return numbersInRange;
    }

    private void generateFibonacci(int n) {
        long num1 = 0;
        long num2 = 1;
        for (int i = 1; i < n; i++) {
            long sum = num1 + num2;
            num1 = num2;
            num2 = sum;
            numbers.add(sum);
        }
    }
}
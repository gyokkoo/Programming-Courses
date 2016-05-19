package _05_CalculateSequence;

import java.util.ArrayDeque;
import java.util.Scanner;

public class CalculateSequence {

    private static final int COUNT = 50;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        long startNumber = scanner.nextLong();

        ArrayDeque<Long> sequence = new ArrayDeque<>();
        ArrayDeque<Long> result = new ArrayDeque<>();

        sequence.add(startNumber);
        for (int i = 0; i < COUNT; i++) {
            long currentNumber = sequence.poll();
            sequence.add(currentNumber + 1);
            sequence.add(2 * currentNumber + 1);
            sequence.add(currentNumber + 2);

            result.add(currentNumber);
        }

        while (result.size() >= 2) {
            System.out.print(result.poll() + " ");
        }
        System.out.println(result.poll());

    }
}
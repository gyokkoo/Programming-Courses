package methodsHomework._05_FibonacciNumbers;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;

public class FibonacciNumbersMain {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int startPosition = Integer.parseInt(reader.readLine());
        int endPosition = Integer.parseInt(reader.readLine());

        Fibonacci fibonacci = new Fibonacci(endPosition);
        ArrayList<Long> numbers = fibonacci.getNumbersInRange(startPosition, endPosition);

        for (int i = 0; i < numbers.size() - 1; i++) {
            System.out.print(numbers.get(i) + ", ");
        }

        System.out.println(numbers.get(numbers.size() - 1));
    }
}

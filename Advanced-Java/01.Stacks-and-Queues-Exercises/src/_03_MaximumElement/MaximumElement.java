package _03_MaximumElement;

import java.util.*;

public class MaximumElement {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();

        Stack<Integer> numbers = new Stack<>();
        Stack<Integer> maxNumbers = new Stack<>();
        int max = Integer.MIN_VALUE;
        for (int i = 0; i < n; i++) {
            int type = scanner.nextInt();
            switch (type) {
                case 1:
                    int x = scanner.nextInt();
                    numbers.push(x);
                    if (max <= x) {
                        max = x;
                        maxNumbers.push(max);
                    }
                    break;
                case 2:
                    int numberToPop = numbers.pop();
                    if (numberToPop == max) {
                        maxNumbers.pop();
                        max = maxNumbers.size() > 0 ? maxNumbers.peek() : Integer.MIN_VALUE;
                    }
                    break;
                case 3:
                    System.out.println(maxNumbers.peek());
                    break;
            }
        }
    }
}

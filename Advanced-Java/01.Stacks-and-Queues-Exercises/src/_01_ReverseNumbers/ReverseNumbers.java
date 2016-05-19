package _01_ReverseNumbers;

import java.util.Arrays;
import java.util.Scanner;
import java.util.Stack;

public class ReverseNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine();
        Stack<Integer> numbers = new Stack<>();

        Arrays.stream(line.split(" ")).mapToInt(Integer::parseInt).forEach(numbers::push);

        while (numbers.size() > 0) {
            System.out.print(numbers.pop() + " ");
        }
        System.out.println();
    }
}
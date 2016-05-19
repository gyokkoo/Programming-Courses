package _02_BasicStackOperations;

import java.util.Arrays;
import java.util.Scanner;
import java.util.Stack;

public class BasicStackOperations {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int countOfElementsToAdd = scanner.nextInt();
        int countOfElementsToRemove = scanner.nextInt();
        int elementToCheck = scanner.nextInt();

        Stack<Integer> stack = new Stack<>();
        for (int i = 0; i < countOfElementsToAdd; i++) {
            int elementToAdd = scanner.nextInt();
            stack.add(elementToAdd);
        }

        for (int i = 0; i < countOfElementsToRemove; i++) {
            stack.pop();
        }

        if (stack.contains(elementToCheck)) {
            System.out.println(true);
        } else {
            System.out.println(Arrays.stream(stack.toArray()).sorted().findFirst().orElse(0));
        }
    }
}
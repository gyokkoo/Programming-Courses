package _04_BasicQueueOperations;

import java.util.ArrayDeque;
import java.util.Arrays;
import java.util.Queue;
import java.util.Scanner;

public class BasicQueueOperations {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int countOfElementsToAdd = scanner.nextInt();
        int countOfElementsToRemove = scanner.nextInt();
        int elementToCheck = scanner.nextInt();

        Queue<Integer> queue = new ArrayDeque<>();
        for (int i = 0; i < countOfElementsToAdd; i++) {
            int elementToAdd = scanner.nextInt();
            queue.add(elementToAdd);
        }

        for (int i = 0; i < countOfElementsToRemove; i++) {
            queue.poll();
        }

        if (queue.contains(elementToCheck)) {
            System.out.println(true);
        } else {
            Object min = Arrays.stream(queue.toArray()).sorted().findFirst().orElse(0);
            System.out.println(min);
        }
    }
}

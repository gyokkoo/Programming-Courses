package _1_SecondNature;

import java.util.LinkedList;
import java.util.Scanner;
import java.util.Stack;

public class SecondNature {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String[] firstLine = scanner.nextLine().split(" ");
        String[] secondLine = scanner.nextLine().split(" ");

        LinkedList<Integer> flowers = new LinkedList<>();
        for (int i = 0; i < firstLine.length; i++) {
            flowers.add(Integer.parseInt(firstLine[i]));
        }
        Stack<Integer> buckets = new Stack<>();
        for (int i = 0; i < secondLine.length; i++) {
            buckets.add(Integer.parseInt(secondLine[i]));
        }

        LinkedList<Integer> secondNature = new LinkedList<>();
        while (!flowers.isEmpty() && !buckets.isEmpty()) {
            int currentFlower = flowers.peek();
            int currentBucket = buckets.peek();

            int remainder = currentBucket - currentFlower;
            if (remainder == 0) {
                secondNature.add(currentFlower);
                buckets.pop();
            }

            if (0 < remainder && 1 < buckets.size()) {
                buckets.pop();
                int nextBucket = buckets.pop() + remainder;
                buckets.push(nextBucket);
            } else if (remainder > 0 && buckets.size() == 1 && !flowers.isEmpty()) {
                buckets.pop();
                buckets.push(remainder);
            }

            flowers.poll();

            if (remainder < 0) {
                currentFlower -= currentBucket;
                buckets.pop();
                flowers.addFirst(currentFlower);
            }
        }

        if (flowers.size() == 0) {
            while (!buckets.isEmpty()) {
                System.out.print(buckets.pop() + " ");
            }
        } else {
            for (Integer flower : flowers) {
                System.out.print(flower + " ");
            }
        }
        System.out.println();

        if (secondNature.isEmpty()) {
            System.out.print("None");
        } else {
            for (Integer flower : secondNature) {
                System.out.print(flower + " ");
            }
        }
        System.out.println();
    }
}

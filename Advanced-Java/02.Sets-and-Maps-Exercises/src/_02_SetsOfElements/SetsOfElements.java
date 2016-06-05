package _02_SetsOfElements;

import java.util.LinkedHashSet;
import java.util.Scanner;
import java.util.Set;

public class SetsOfElements {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int firstSetSize = scanner.nextInt();
        int secondSetSize = scanner.nextInt();

        Set<Integer> firstSet = new LinkedHashSet<>();
        Set<Integer> secondSet = new LinkedHashSet<>();

        for (int i = 0; i < firstSetSize; i++) {
            int numberToAdd = scanner.nextInt();
            firstSet.add(numberToAdd);
        }

        for (int i = 0; i < secondSetSize; i++) {
            int numberToAdd = scanner.nextInt();
            if (firstSet.contains(numberToAdd)) {
                secondSet.add(numberToAdd);
            }
        }

        secondSet.forEach(number -> System.out.print(number + " "));
    }
}

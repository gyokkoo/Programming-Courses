package _11_PoisonousPlants;

import java.util.*;

public class _11_PoisonousPlants {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int countOfPlants = Integer.parseInt(scanner.nextLine());
        int[] plants = new int[countOfPlants];
        String[] line = scanner.nextLine().split(" ");
        for (int i = 0; i < countOfPlants; i++) {
            plants[i] = Integer.parseInt(line[i]);
        }

        int[] daySpan = new int[countOfPlants];
        daySpan[0] = -1;
        int min = plants[0];
        int maxSpan = 0;

        for (int i = 1; i < plants.length; i++) {
            if (plants[i] <= min) {
                min = plants[i];
                daySpan[i] = -1;
                continue;
            }

            daySpan[i] = 1;

            for (int j = i - 1; j >= 0; j--) {
                if (plants[i] > plants[j]) {
                    if (maxSpan < daySpan[i]) {
                        maxSpan = daySpan[i];
                    }
                    break;
                } else {
                    if (daySpan[j] >= daySpan[i]) {
                        daySpan[i] = daySpan[j] + 1;
                        if (maxSpan < daySpan[i]) {
                            maxSpan = daySpan[i];
                            break;
                        }
                    }
                }
            }
        }

        System.out.println(maxSpan);
    }
}
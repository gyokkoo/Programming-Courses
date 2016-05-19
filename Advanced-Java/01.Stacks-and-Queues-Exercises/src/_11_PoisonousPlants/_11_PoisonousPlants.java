package _11_PoisonousPlants;

import java.util.*;

public class _11_PoisonousPlants {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        long countOfPlants = scanner.nextLong();

        LinkedList<Long> plants = new LinkedList<>();
        for (int i = 0; i < countOfPlants; i++) {
            long amountOfPesticides = scanner.nextInt();
            plants.add(amountOfPesticides);
        }

        long days = 0;
        while (true) {
            Stack<Long> removedPlants = new Stack<>();
            for (int i = 0; i < plants.size() - 1; i++) {
                long currentPlant = plants.get(i);
                long nextPlant = plants.get(i + 1);

                if (nextPlant > currentPlant) {
                    removedPlants.push(nextPlant);
                }
            }

            if (removedPlants.size() == 0) {
                System.out.println(days);
                return;
            }

            while (removedPlants.size() > 0) {
                plants.remove(removedPlants.pop());
            }

            days++;
        }
    }
}
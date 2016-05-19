package _06_TruckTour;

import java.util.*;

public class TruckTour {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int countOfPumps = scanner.nextInt();

        Queue<Long> queue = new ArrayDeque<>();
        for (int i = 0; i < countOfPumps; i++) {
            long amountOfPetrol = scanner.nextLong();
            long distanceToNextPump = scanner.nextLong();

            long fuel = amountOfPetrol - distanceToNextPump;
            queue.add(fuel);
        }

        int index = 0;
        while (true) {
            long fuel = 0;
            int visitedPumps = 1;
            Queue<Long> currentQueue = new ArrayDeque<>(queue);
            for (int j = 0; j < countOfPumps; j++) {
                long currentFuel = currentQueue.poll();
                currentQueue.add(currentFuel);
                fuel += currentFuel;
                if (fuel < 0) {
                    queue.add(queue.poll());
                    index++;
                    break;
                }

                visitedPumps++;
                if (visitedPumps == countOfPumps) {
                    System.out.println(index);
                    return;
                }
            }
        }
    }
}


package _21_ParkingSystem;

import java.util.HashSet;
import java.util.Scanner;

public class ParkingSystem {
    private static int rows;
    private static int columns;
    private final static HashSet<String> takenSpots = new HashSet<>();

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] dimensions = scanner.nextLine().split("\\s+");
        rows = Integer.parseInt(dimensions[0]);
        columns = Integer.parseInt(dimensions[1]);
        while (true) {
            String[] input = scanner.nextLine().split("\\s+");
            if (input[0].equals("stop")) {
                break;
            }

            int entryRow = Integer.parseInt(input[0]);
            int wantedRow = Integer.parseInt(input[1]);
            int wantedCol = Integer.parseInt(input[2]);
            int steps = Math.abs(wantedRow - entryRow) + wantedCol + 1;
            if (wantedCol <= 0 || columns <= wantedCol) {
                System.out.printf("Row %d full%n", wantedRow);
                continue;
            }
            String wantedSpot = wantedRow + " " + wantedCol;
            if (takenSpots.contains(wantedSpot)) {
                int mod = 1;
                while (true) {
                    int newColLeft = attemptLeft(mod, wantedCol, wantedRow);
                    if (newColLeft > 0) {
                        steps = Math.abs(wantedRow - entryRow) + newColLeft + 1;
                        System.out.println(steps);
                        break;
                    }
                    int newColRight = attemptRight(mod, wantedCol, wantedRow);
                    if (newColRight > 0) {
                        steps = Math.abs(wantedRow - entryRow) + newColRight + 1;
                        System.out.println(steps);
                        break;
                    }
                    if (newColLeft == -2 && newColRight == -2) {
                        System.out.printf("Row %d full%n", wantedRow);
                        break;
                    }
                    mod++;
                }
            } else {
                takenSpots.add(wantedSpot);
                System.out.println(steps);
            }
        }
    }

    private static int attemptRight(int mod, int wantedCol, int wantedRow) {
        int newCol = wantedCol + mod;
        if (newCol >= columns) {
            return -2;
        }

        String newSpot = wantedRow + " " + newCol;
        if (takenSpots.contains(newSpot)) {
            return -1;
        } else {
            takenSpots.add(newSpot);
            return newCol;
        }
    }

    private static int attemptLeft(int mod, int wantedCol, int wantedRow) {
        int newCol = wantedCol - mod;
        if (newCol <= 0) {
            return -2;
        }

        String newSpot = wantedRow + " " + newCol;
        if (takenSpots.contains(newSpot)) {
            return -1;
        } else {
            takenSpots.add(newSpot);
            return newCol;
        }
    }
}

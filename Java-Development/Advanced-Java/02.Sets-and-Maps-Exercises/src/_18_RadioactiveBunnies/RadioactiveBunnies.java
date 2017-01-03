package _18_RadioactiveBunnies;

import java.util.Scanner;

public class RadioactiveBunnies {
    private static int rows;
    private static int columns;
    private static int playerRow;
    private static int playerCol;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] dimensions = scanner.nextLine().split("\\s+");

        rows = Integer.parseInt(dimensions[0]);
        columns = Integer.parseInt(dimensions[1]);
        char[][] matrixA = new char[rows][columns];
        char[][] matrixB = new char[rows][columns];

        for (int i = 0; i < rows; i++) {
            String rowLine = scanner.nextLine();
            if (rowLine.contains("P")) {
                playerRow = i;
                playerCol = rowLine.indexOf("P");
            }

            matrixA[i] = rowLine.toCharArray();
            matrixB[i] = rowLine.toCharArray();
        }

        matrixB[playerRow][playerCol] = '.';

        String directions = scanner.nextLine();
        boolean hasWon = false;
        for (int i = 0; i < directions.length(); i++) {
            spreadBunnies(matrixA, matrixB);
            char direction = directions.charAt(i);
            switch (direction) {
                case 'U':
                    playerRow--;
                    if (playerRow < 0) {
                        hasWon = true;
                        playerRow++;
                    }
                    break;
                case 'D':
                    playerRow++;
                    if (playerRow >= rows) {
                        hasWon = true;
                        playerRow--;
                    }
                    break;
                case 'R':
                    playerCol++;
                    if (playerCol >= columns) {
                        hasWon = true;
                        playerCol--;
                    }
                    break;
                case 'L':
                    playerCol--;
                    if (playerCol < 0) {
                        hasWon = true;
                        playerCol++;
                    }
                    break;
            }

            if (hasWon) {
                printMatrix(matrixA);
                System.out.printf("won: %d %d%n", playerRow, playerCol);
                return;
            }

            if (matrixA[playerRow][playerCol] == 'B') {
                printMatrix(matrixA);
                System.out.printf("dead: %d %d%n", playerRow, playerCol);
                return;
            }
        }
    }

    private static void spreadBunnies(char[][] matrixA, char[][] matrixB) {
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                if (matrixA[i][j] == 'B') {
                    if (i - 1 >= 0)
                        matrixB[i - 1][j] = 'B';
                    if (i + 1 < rows)
                        matrixB[i + 1][j] = 'B';
                    if (j - 1 >= 0)
                        matrixB[i][j - 1] = 'B';
                    if (j + 1 < columns)
                        matrixB[i][j + 1] = 'B';
                }
            }
        }

        for (int i = 0; i < rows; i++) {
            System.arraycopy(matrixB[i], 0, matrixA[i], 0, columns);
        }
    }

    private static void printMatrix(char[][] matrixA) {
        for (int i = 0; i < rows; i++) {
            System.out.println(matrixA[i]);
        }
    }
}
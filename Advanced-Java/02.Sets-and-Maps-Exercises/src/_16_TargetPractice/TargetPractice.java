package _16_TargetPractice;

import java.util.Scanner;

public class TargetPractice {
    private static int rows;
    private static int columns;
    private static Character[][] matrix;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] dimensions = scanner.nextLine().split(" ");
        String snakeString = scanner.nextLine();
        String[] shotArgs = scanner.nextLine().split("\\s+");

        rows = Integer.parseInt(dimensions[0]);
        columns = Integer.parseInt(dimensions[1]);
        matrix = new Character[rows][columns];

        int targetRow = Integer.parseInt(shotArgs[0]);
        int targetCol = Integer.parseInt(shotArgs[1]);
        int radius = Integer.parseInt(shotArgs[2]);

        fillZigZagMatrix(snakeString);

        fireAShot(targetRow, targetCol, radius);

        dropCharacters();

        printMatrix();
    }

    private static void printMatrix() {
        for (int row = 0; row < rows; row++) {
            for (int col = 0; col < columns; col++) {
                System.out.print(matrix[row][col]);
            }
            System.out.println();
        }
    }

    private static void dropCharacters() {
        for (int col = 0; col < columns; col++) {
            for (int row = rows - 1; row >= 0; row--) {
                if (matrix[row][col] == ' ') {
                    for (int i = row - 1; i >= 0; i--) {
                        if (matrix[i][col] != ' ') {
                            matrix[row][col] = matrix[i][col];
                            matrix[i][col] = ' ';
                            break;
                        }
                    }
                }
            }
        }
    }

    private static void fireAShot(int targetRow, int targetCol, int radius) {
        matrix[targetRow][targetCol] = ' ';
        for (int row = 0; row < rows; row++) {
            for (int col = 0; col < columns; col++) {
                try {
                    int deltaRow = row - targetRow;
                    int deltaCol = col - targetCol;
                    if ((deltaRow * deltaRow) + (deltaCol * deltaCol) <= radius * radius) {
                        matrix[row][col] = ' ';
                    }
                } catch (IndexOutOfBoundsException e) {
                    // ignored
                }
            }
        }
    }

    private static void fillZigZagMatrix(String snakeString) {
        int row = rows - 1;
        int col = columns - 1;
        int snakeIndex = 0;
        int cellCounter = 0;
        String direction = "left";
        matrix[row][col] = snakeString.charAt(0);

        while (cellCounter < rows * columns) {
            matrix[row][col] = snakeString.charAt(snakeIndex = snakeIndex == snakeString.length() ? 0 : snakeIndex);
            if (direction.equals("left")) {
                if (col - 1 >= 0) {
                    col--;
                } else {
                    row--;
                    direction = "right";
                }
            } else if (direction.equals("right")) {
                if (col + 1 < columns) {
                    col++;
                } else {
                    row--;
                    direction = "left";
                }
            }

            cellCounter++;
            snakeIndex++;
        }
    }
}
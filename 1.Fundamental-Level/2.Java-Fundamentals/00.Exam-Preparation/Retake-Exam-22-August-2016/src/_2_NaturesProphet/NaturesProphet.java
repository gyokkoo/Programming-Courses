package _2_NaturesProphet;

import java.util.Scanner;

public class NaturesProphet {

    private static final String END_MESSAGE = "Bloom Bloom Plow";

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] dimensions = scanner.nextLine().split(" ");
        int rows = Integer.parseInt(dimensions[0]);
        int columns = Integer.parseInt(dimensions[1]);

        int[][] matrix = new int[rows][columns];
        String line = scanner.nextLine();
        while (!END_MESSAGE.equals(line)) {
            String[] plantDimensions = line.split(" ");
            int targetRow = Integer.parseInt(plantDimensions[0]);
            int targetCol = Integer.parseInt(plantDimensions[1]);

            matrix[targetRow][targetCol] += 1;
            for (int i = 0; i < columns; i++) {
                if (targetCol == i) {
                    continue;
                }
                matrix[targetRow][i] += 1;
            }

            for (int i = 0; i < rows; i++) {
                if (targetRow == i) {
                    continue;
                }
                matrix[i][targetCol] += 1;
            }

            line = scanner.nextLine();
        }

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                System.out.print(matrix[i][j] + " ");
            }
            System.out.println();
        }
    }
}
package _17_LegoBlocks;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class LegoBlocks {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int rows = Integer.parseInt(scanner.nextLine());

        int[][] firstArr = new int[rows][];
        int[][] secondArr = new int[rows][];

        fillMatrix(scanner, rows, firstArr);
        fillMatrix(scanner, rows, secondArr);

        int cols = firstArr[0].length + secondArr[0].length;
        int[][] matrix = new int[rows][cols];
        boolean isFitting = true;
        for (int row = 0; row < rows; row++) {
            if (cols == firstArr[row].length + secondArr[row].length) {
                int i = secondArr[row].length - 1;
                for (int col = 0; col < cols; col++) {
                    if (col < firstArr[row].length) {
                        matrix[row][col] = firstArr[row][col];
                    } else {
                        matrix[row][col] = secondArr[row][i];
                        i--;
                    }
                }
            } else {
                isFitting = false;
            }
        }
        if (isFitting) {
            printMatrix(matrix, rows);
        } else {
            System.out.println("The total number of cells is: " + countCells(firstArr, secondArr, rows));
        }
    }

    private static int countCells(int[][] firstArr, int[][] secondArr, int rows) {
        int cells = 0;
        for (int row = 0; row < rows; row++) {
            for (int col = 0; col < firstArr[row].length; col++) {
                cells++;
            }
            for (int col = 0; col < secondArr[row].length; col++) {
                cells++;
            }
        }
        return cells;
    }

    private static void fillMatrix(Scanner scanner, int rows, int[][] firstArr) {
        for (int row = 0; row < rows; row++) {
            String[] line = scanner.nextLine().replaceAll("\\s+", " ").trim().split(" ");
            firstArr[row] = new int[line.length];
            for (int col = 0; col < line.length; col++) {
                firstArr[row][col] = Integer.parseInt(line[col]);
            }
        }
    }

    private static void printMatrix(int[][] arr, int rows) {
        List<Integer> output = new ArrayList<>();
        for (int row = 0; row < rows; row++) {
            for (int col = 0; col < arr[row].length; col++) {
                output.add(arr[row][col]);
            }
            System.out.println(output);
            output.clear();
        }
    }
}

import java.util.Scanner;

public class _3_RubiksMatrix {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] dimensions = scanner.nextLine().split(" ");
        int rows = Integer.parseInt(dimensions[0]);
        int columns = Integer.parseInt(dimensions[1]);
        int[][] matrix = new int[rows][columns];
        int[][] firstMatrix = new int[rows][columns];
        int num = 1;
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                matrix[i][j] = num;
                firstMatrix[i][j] = num;
                num++;
            }
        }

        int n = Integer.parseInt(scanner.nextLine());
        for (int b = 0; b < n; b++) {
            String[] moveArgs = scanner.nextLine().split(" ");
            int rowOrCol = Integer.parseInt(moveArgs[0]);
            String direction = moveArgs[1];
            int moves = Integer.parseInt(moveArgs[2]);
            switch (direction) {
                case "left":
                    moveLeft(columns, matrix[rowOrCol], moves % rows);
                    break;
                case "right":
                    moveRight(columns, matrix[rowOrCol], moves % rows);
                    break;
                case "up":
                    moveUp(rows, columns, matrix, rowOrCol, moves % columns);
                    break;
                case "down":
                    moveDown(rows, columns, matrix, rowOrCol, moves % columns);
                    break;
            }
        }

        rearrange(rows, columns, matrix, firstMatrix);
    }

    private static void rearrange(int rows, int columns, int[][] matrix, int[][] firstMatrix) {
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                if(matrix[i][j] == firstMatrix[i][j]) {
                    System.out.println("No swap required");
                } else {
                    int targetNum = firstMatrix[i][j];
                    boolean isFound = false;
                    for (int k = 0; k < rows; k++) {
                        for (int l = 0; l < columns; l++) {
                            if(matrix[k][l] == targetNum) {
                                System.out.println(String.format("Swap (%d, %d) with (%d, %d)", i, j, k,l));
                                int oldValue = matrix[k][l];
                                matrix[k][l] = matrix[i][j];
                                matrix[i][j] = oldValue;
                                isFound = true;
                                break;
                            }
                        }
                        if(isFound) {
                            break;
                        }
                    }
                }
            }
        }
    }

    private static void moveDown(int rows, int columns, int[][] matrix, int rowOrCol, int moves) {
        for (int a = 0; a < moves; a++) {
            int[] arr = new int[columns];
            int index = 0;
            for (int i = 0; i < rows; i++) {
                arr[index] = matrix[i][rowOrCol];
                index++;
            }
            shiftRight(arr);
            index = 0;
            for (int i = 0; i < rows; i++) {
                matrix[i][rowOrCol] = arr[index];
                index++;
            }
        }
    }

    private static void moveUp(int rows, int columns, int[][] matrix, int rowOrCol, int moves) {
        for (int a = 0; a < moves; a++) {
            int[] arr = new int[columns];
            int index = 0;
            for (int i = 0; i < rows; i++) {
                arr[index] = matrix[i][rowOrCol];
                index++;
            }
            shiftLeft(arr);
            index = 0;
            for (int i = 0; i < rows; i++) {
                matrix[i][rowOrCol] = arr[index];
                index++;
            }
        }
    }

    private static void moveRight(int columns, int[] ints, int moves) {
        for (int a = 0; a < moves; a++) {
            int[] arr = new int[columns];
            int index = 0;
            for (int j = 0; j < columns; j++) {
                arr[index] = ints[j];
                index++;
            }
            shiftRight(arr);
            index = 0;
            for (int j = 0; j < columns; j++) {
                ints[j] = arr[index];
                index++;
            }
        }
    }

    private static void moveLeft(int columns, int[] ints, int moves) {
        for (int a = 0; a < moves; a++) {
            int[] arr = new int[columns];
            int index = 0;
            for (int j = 0; j < columns; j++) {
                arr[index] = ints[j];
                index++;
            }
            shiftLeft(arr);
            index = 0;
            for (int j = 0; j < columns; j++) {
                ints[j] = arr[index];
                index++;
            }
        }
    }

    private static void shiftRight(int[] arr) {
        int lastElement = arr[arr.length - 1];
        System.arraycopy(arr, 0, arr, 1, arr.length - 1);
        arr[0] = lastElement;
    }

    private static void shiftLeft(int[] arr) {
        int firstElement = arr[0];
        System.arraycopy(arr, 1, arr, 0, arr.length - 1);
        arr[arr.length - 1] = firstElement;
    }
}

package _2_CubicsRube;

import java.util.Scanner;

public class CubicsRube {

    private static final String END_MESSAGE = "Analyze";

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int n = Integer.parseInt(scanner.nextLine());
        long[][][] matrix = new long[n][n][n];

        String line;
        int shootCount = 0;
        while (!END_MESSAGE.equals(line = scanner.nextLine())) {
            String[] data = line.split(" ");
            int i = Integer.parseInt(data[0]);
            int j = Integer.parseInt(data[1]);
            int k = Integer.parseInt(data[2]);
            long number = Long.parseLong(data[3]);

            try {
                matrix[i][j][k] += number;
            } catch (ArrayIndexOutOfBoundsException ignored) {
            }
        }

        long cellSum = 0;
        long zeroCount = 0;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n; j++) {
                for (int k = 0; k < n; k++) {
                    cellSum += matrix[i][j][k];
                    if (matrix[i][j][k] == 0) {
                        zeroCount++;
                    }
                }
            }
        }

        System.out.println(cellSum);
        System.out.println(zeroCount);
    }
}
package _19_Crossfire;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class Crossfire {
    private static final String END_MESSAGE = "Nuke it from orbit";

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] dimensions = scanner.nextLine().split("\\s+");
        int rows = Integer.parseInt(dimensions[0]);
        int columns = Integer.parseInt(dimensions[1]);

        ArrayList<ArrayList<Integer>> matrix = new ArrayList<>();
        int number = 1;
        for (int row = 0; row < rows; row++) {
            ArrayList<Integer> rowLine = new ArrayList<>();
            for (int col = 0; col < columns; col++) {
                rowLine.add(number++);
            }
            matrix.add(rowLine);
        }

        String inputLine = scanner.nextLine();
        while (!inputLine.equals(END_MESSAGE)) {
            String[] params = inputLine.split("\\s+");
            int targetRow = Integer.parseInt(params[0]);
            int targetCol = Integer.parseInt(params[1]);
            int radius = Integer.parseInt(params[2]);

            if (0 <= targetRow && targetRow < matrix.size() && 0 <= targetCol && targetCol < matrix.get(targetRow).size()) {
                matrix.get(targetRow).set(targetCol, -1);
            }

            for (int r = 1; r <= radius; r++) {
                int previousRow = targetRow - r;
                int nextRow = targetRow + r;
                int previousCol = targetCol - r;
                int nextCol = targetCol + r;

                if (0 <= targetRow && targetRow < matrix.size()) {
                    if (0 <= previousCol && previousCol < matrix.get(targetRow).size()) {
                        matrix.get(targetRow).set(previousCol, -1);
                    }
                    if (0 <= nextCol && nextCol < matrix.get(targetRow).size()) {
                        matrix.get(targetRow).set(nextCol, -1);
                    }
                }

                if (0 <= targetCol) {
                    if (0 <= previousRow && previousRow < matrix.size() && targetCol < matrix.get(previousRow).size()) {
                        matrix.get(previousRow).set(targetCol, -1);
                    }
                    if (0 <= nextRow && nextRow < matrix.size() && targetCol < matrix.get(nextRow).size()) {
                        matrix.get(nextRow).set(targetCol, -1);
                    }
                }
            }

            filterMatrix(matrix);

            inputLine = scanner.nextLine();
        }

        for (ArrayList<Integer> list : matrix) {
            if (!list.contains(-1)) {
                for (int j = 0; j < list.size(); j++) {
                    System.out.print(list.get(j) + " ");
                }
            }

            if (!list.isEmpty()) {
                System.out.println();
            }
        }

    }

    private static void filterMatrix(ArrayList<ArrayList<Integer>> matrix) {
        for (int row = 0; row < matrix.size(); row++) {
            matrix.get(row).removeAll(Arrays.asList((new Integer[]{-1})));
        }
        matrix.removeAll(Arrays.asList(new ArrayList<Integer>()));
    }
}

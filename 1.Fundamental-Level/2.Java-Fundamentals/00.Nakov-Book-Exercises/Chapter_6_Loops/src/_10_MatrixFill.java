import java.util.Scanner;

public class _10_MatrixFill {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("N = ");
        int n = scanner.nextInt();
        int[][] myArray = new int[n][n];

        for (int row = 0; row < n; row++) {
            for (int col = 0; col < n; col++) {
                myArray[row][col] = 1 + row + col;
                System.out.print(myArray[row][col] + " ");
            }
            System.out.println();
        }
    }
}

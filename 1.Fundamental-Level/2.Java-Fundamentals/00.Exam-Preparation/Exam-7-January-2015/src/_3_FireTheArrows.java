import java.util.Scanner;

public class _3_FireTheArrows {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        char[][] matrix = new char[n][];

        for (int i = 0; i < n; i++) {
            String line = scanner.nextLine();
            matrix[i] = new char[line.length()];
            for (int j = 0; j < line.length(); j++) {
                matrix[i][j] = line.charAt(j);
            }
        }

        for (int i = 0; i < n; i++) {
            makeMove(n, matrix);
        }

        printMatrix(n, matrix);

    }

    private static void printMatrix(int n, char[][] matrix) {
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < matrix[i].length; j++) {
                System.out.print(matrix[i][j]);
            }
            System.out.println();
        }
    }

    private static void makeMove(int n, char[][] matrix) {
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < matrix[i].length; j++) {
                if(matrix[i][j] == '<') {
                    if(j - 1 >= 0 && matrix[i][j-1] == 'o') {
                        matrix[i][j - 1] = '<';
                        matrix[i][j] = 'o';
                    }
                } else if(matrix[i][j] == '>') {
                    if(j + 1 < matrix[i].length && matrix[i][j+1] == 'o') {
                        matrix[i][j+1] = '>';
                        matrix[i][j] = 'o';
                    }
                } else if(matrix[i][j] == 'v') {
                    if(i + 1 < n && matrix[i+1][j] == 'o') {
                        matrix[i+1][j] = 'v';
                        matrix[i][j] = 'o';
                    }
                } else if(matrix[i][j] == '^') {
                    if(i - 1 >= 0 && matrix[i-1][j] == 'o') {
                        matrix[i-1][j] = '^';
                        matrix[i][j] = 'o';
                    }
                }
            }
        }
    }
}

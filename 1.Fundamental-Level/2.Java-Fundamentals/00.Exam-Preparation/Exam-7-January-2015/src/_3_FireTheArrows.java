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
            for (int j = 0; j < matrix[i].length; j++) {
                if(matrix[i][j] == '<') {

                } else if(matrix[i][j] == )
            }
        }
    }
}

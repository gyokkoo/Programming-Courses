import java.util.Scanner;

public class _3_DrawFigure {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();

        System.out.println(newString('*', n));
        int dotCounter = 1;
        int asterisk = n - 2;
        for (int i = 0; i < n/2 - 1; i++) {
            System.out.printf("%s%s%s%n", newString('.', dotCounter), newString('*', asterisk),
                    newString('.', dotCounter));
            dotCounter++;
            asterisk -= 2;
        }
        System.out.println(newString('.', n/2) + "*" + newString('.', n/2));
        for (int i = 0; i < n/2 - 1; i++) {
            dotCounter--;
            asterisk += 2;
            System.out.printf("%s%s%s%n", newString('.', dotCounter), newString('*', asterisk),
                    newString('.', dotCounter));

        }
        System.out.println(newString('*', n));
    }

    public static String newString(char ch, int n) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n ; i++) {
            sb.append(ch);
        }

        return  sb.toString();
    }
}

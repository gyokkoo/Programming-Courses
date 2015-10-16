import java.util.Scanner;

public class _03_FormattingNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter an integer a (0 <= a <= 500), a floating point double b and c.");
        int a = scanner.nextInt();
        double b = scanner.nextDouble();
        double c = scanner.nextDouble();

        String binaryA = Integer.toHexString(a);
        String formatBinary = String.format("%10s", binaryA).replace(' ', '0');

        System.out.printf("%-10X|%s|%10.2f|%-10.3f", a, formatBinary, b, c);
    }
}

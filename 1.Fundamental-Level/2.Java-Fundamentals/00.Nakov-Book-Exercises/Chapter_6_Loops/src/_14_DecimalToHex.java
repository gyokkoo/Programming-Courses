import java.util.Scanner;

public class _14_DecimalToHex {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a number");
        int number = scanner.nextInt();

        System.out.println("The number in HEX is " +
                Integer.toHexString(number).toUpperCase());
    }
}

import java.util.Scanner;

public class _15_HexToDecimal {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a HEX number,");
        String hexNumber = scanner.next();
        try {
            int number = Integer.parseInt(hexNumber,16);
            System.out.println("The HEX number in decimal is " + number);
        } catch (Exception exc) {
            System.out.println("Failed parsing!");
        }
    }
}

import java.io.IOException;
import java.util.Scanner;

public class _13_BinaryToDecimal {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Please, enter a binary number");
        String binaryNumber = scanner.next();
        try {
            int decimalNumber = Integer.parseInt(binaryNumber, 2);
            System.out.println("The number in decimal is " + decimalNumber);
        } catch(Exception exc) {
            System.out.println("Not a binary number!");
        }

    }
}

import java.util.Scanner;

public class _12_DecimalToBinary {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter decimal number.");
        int number = scanner.nextInt();

        String binaryNumber = Integer.toBinaryString(number);

        System.out.println("The number in binary is " + binaryNumber);
    }
}

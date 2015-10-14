import java.util.Scanner;

public class _04_ChekThirdBit {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a number.");
        int number = scanner.nextInt();
        System.out.println("The number in binary");
        System.out.println(Integer.toBinaryString(number));
        boolean isThirdBitOne = ((number >> 2) & 1) == 1;

        System.out.println("Is third bit one ? -> " + isThirdBitOne);
    }
}
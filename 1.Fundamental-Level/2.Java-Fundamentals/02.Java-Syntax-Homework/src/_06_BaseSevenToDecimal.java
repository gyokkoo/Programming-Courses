import java.util.Scanner;

public class _06_BaseSevenToDecimal {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter Base-7 number.");
        int n = scanner.nextInt();
        int sevenBaseNumber = Math.abs(n);

        int decimalNum = 0;
        int pow = 0;
        while(sevenBaseNumber > 0) {
            int lastDigit = sevenBaseNumber % 10;
            decimalNum += lastDigit * (int) Math.pow(7, pow);
            pow++;
            sevenBaseNumber /= 10;
        }

        System.out.println(n < 0 ? ("-" + decimalNum): decimalNum);
    }
}

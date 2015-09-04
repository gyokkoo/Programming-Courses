import java.util.Locale;
import java.util.Scanner;

public class _06_FormattingNumbers {
	public static void main(String[] args) {
		Locale.setDefault(Locale.ROOT);
		Scanner scanner = new Scanner(System.in);
		System.out.println("Enter three numbers.");
		int firstNumber = scanner.nextInt();
		double secondNumber = scanner.nextDouble();
		double thirdNumber = scanner.nextDouble();
		
		String firstNumberAsHex = Integer.toHexString(firstNumber).toUpperCase();
		String firstNumberAsBinary = String.format("%10s", Integer.toBinaryString(firstNumber)).replace(' ', '0');
		System.out.printf("|%-10s|%s|%10.2f|%-10.3f|", firstNumberAsHex, firstNumberAsBinary, secondNumber, thirdNumber);
	}
}

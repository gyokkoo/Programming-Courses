import java.util.Locale;
import java.util.Scanner;

public class _04_TheSmallestOfThreeNumbers {
	public static void main(String[] args) {
		Locale.setDefault(Locale.ROOT);
		Scanner scanner = new Scanner(System.in);
		System.out.println("Enter three numbers.");
		double firstNumber = scanner.nextDouble();
		double secondNumber = scanner.nextDouble();
		double thirdNumber = scanner.nextDouble();
		
		double smallestNumber = Math.min(Math.min(firstNumber, secondNumber), thirdNumber);
		
		System.out.println("The smallest number is: " + smallestNumber);
	}
}

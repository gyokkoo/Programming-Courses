import java.util.Scanner;

public class _02_ChekDivisibility {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		System.out.println("Enter a number.");
		int number = scanner.nextInt();
		boolean isDivisibleByFive = number % 5 == 0;
		boolean isDivisibleBySeven = number % 7 == 0;

		boolean isDivisibleByFiveAndSeven = isDivisibleByFive
				&& isDivisibleBySeven;
		System.out.println("Is number divisible by five and seven? -> " + 
				isDivisibleByFiveAndSeven);
	}
}

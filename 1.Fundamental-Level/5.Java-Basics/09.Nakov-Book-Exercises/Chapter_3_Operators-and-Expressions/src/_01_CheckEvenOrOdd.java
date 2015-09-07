import java.util.Scanner;

public class _01_CheckEvenOrOdd {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		System.out.println("Enter a number.");
		int number = scanner.nextInt();
		
		System.out.println(number % 2 == 0 ? "The number is even." : "The number is odd.");
	}
}

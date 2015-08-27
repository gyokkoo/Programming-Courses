import java.util.Scanner;

public class SumTwoNumbers {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Enter the first number: ");
		int firstNumber = input.nextInt();
		System.out.print("Enter the second number: ");
		int secondNumber = input.nextInt();
		System.out.println("The sum is: " + (firstNumber + secondNumber));
	}
}

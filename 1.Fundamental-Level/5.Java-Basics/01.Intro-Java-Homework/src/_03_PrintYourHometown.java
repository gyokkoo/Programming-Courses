import java.util.Scanner;

public class _03_PrintYourHometown {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("Enter your hometown: ");
		String hometown = input.next();
		System.out.println("Your hometown is " + hometown);
	}
}
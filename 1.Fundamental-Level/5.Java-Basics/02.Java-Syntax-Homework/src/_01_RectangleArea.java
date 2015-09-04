import java.util.Scanner;

public class _01_RectangleArea {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		System.out.println("Enter two sides of a rectangle.");
		int sideA = scanner.nextInt();
		int sideB = scanner.nextInt();
		System.out.println("The area of the rectangle is: " + (sideA * sideB));
	}
}

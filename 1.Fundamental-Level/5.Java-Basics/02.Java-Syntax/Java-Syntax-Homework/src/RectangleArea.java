import java.util.Scanner;

public class RectangleArea {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		System.out.println("Enter the sides of a rectangle.");
		
		System.out.print("a = ");
		int sideA = scanner.nextInt();
		System.out.print("b = ");
		int sideB = scanner.nextInt();
				
		System.out.println("The area of the rectangle is: " + (sideA * sideB));
	}
}

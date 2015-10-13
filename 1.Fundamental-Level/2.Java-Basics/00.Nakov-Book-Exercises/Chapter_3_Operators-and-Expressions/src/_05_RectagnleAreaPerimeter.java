import java.util.Locale;
import java.util.Scanner;

public class _05_RectagnleAreaPerimeter {
	public static void main(String[] args) {
		Locale.setDefault(Locale.ROOT);
		Scanner scanner = new Scanner(System.in);
		System.out.println("Enter the width and the height of rectangle.");
		double width = scanner.nextDouble();
		double height = scanner.nextDouble();
		
		double area = width * height;
		double perimeter = 2 * (width + height);
		System.out.println("The area is: " + area);
		System.out.println("The perimeter is: " + perimeter);
	}
}

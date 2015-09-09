import java.util.Locale;
import java.util.Scanner;

public class _06_CalcTrapezoidArea {
	public static void main(String[] args) {
		Locale.setDefault(Locale.ROOT);
		Scanner scanner = new Scanner(System.in);
		System.out.println("Enter a, b and h.");
		double a = scanner.nextDouble();
		double b = scanner.nextDouble();
		double h = scanner.nextDouble();
		
		double area = (a+b)*h/2;
		System.out.println("The area is: " + area);
	}
}

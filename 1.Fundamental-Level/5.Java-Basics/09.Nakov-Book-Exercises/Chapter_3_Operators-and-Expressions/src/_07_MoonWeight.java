import java.util.Locale;
import java.util.Scanner;

public class _07_MoonWeight {
	public static void main(String[] args) {
		Locale.setDefault(Locale.ROOT);
		Scanner scanner = new Scanner(System.in);
		System.out.println("Enter your weight on the Earth.");
		double earthWeight = scanner.nextDouble();
		
		double moonWeight = earthWeight * 0.17;
		System.out.println("On the moon your weight will be " + moonWeight);
	}
}

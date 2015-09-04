import java.util.Locale;
import java.util.Scanner;

public class _03_PointsInsideFigure {
	public static void main(String[] args) {
		Locale.setDefault(Locale.ROOT);
		Scanner scanner = new Scanner(System.in);
		System.out.println("Enter the coordinates of the point.");
		double x = scanner.nextDouble();
		double y = scanner.nextDouble();
		
		boolean insideTopRectangle = ((x >= 12.5 && x <= 22.5) && (y >= 6 && y <= 8.5));
		boolean insideLeftRectangle = ((x >= 12.5 && x <= 17.5) && (y >= 8.5 && y <= 13.5));
		boolean insideRightRectangle = ((x >= 20 && x <= 22.5) && (y >= 8.5 && y <= 13.5));
		
		if(insideTopRectangle || insideLeftRectangle || insideRightRectangle) {
			System.out.println("Inside");
		}
		else {
			System.out.println("Outside");
		}
	}
}

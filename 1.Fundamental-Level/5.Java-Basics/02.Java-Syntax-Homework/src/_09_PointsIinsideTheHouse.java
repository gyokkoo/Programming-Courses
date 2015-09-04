import java.util.Locale;
import java.util.Scanner;

public class _09_PointsIinsideTheHouse {
	public static void main(String[] args) {
		Locale.setDefault(Locale.ROOT);
		Scanner scanner = new Scanner(System.in);
		System.out.println("Enter the coordinates of the point.");
		double x = scanner.nextDouble();
		double y = scanner.nextDouble();
		
		boolean isRightOfLeftRoof = ((12.5 - 17.5) * (y - 3.5) - (8.5 - 3.5) * (x - 17.5)) <= 0;
		boolean isLeftOfRightRoof = ((22.5 - 17.5) * (y - 3.5) - (8.5 - 3.5) * (x - 17.5)) >= 0;
		boolean insideTriangle = isRightOfLeftRoof && isLeftOfRightRoof && y <= 8.5;
		
		boolean insideSquare = ((x >= 12.5 && x <= 17.5) && (y >= 8.5 && y <= 13.5));
		boolean insideRectangle = ((x >= 20 && x <= 22.5) && (y >= 8.5 && y <= 13.5));
		
		if(insideTriangle || insideSquare || insideRectangle) {
			System.out.println("Inside");
		}
		else {
			System.out.println("Outside");
		}
	}
}

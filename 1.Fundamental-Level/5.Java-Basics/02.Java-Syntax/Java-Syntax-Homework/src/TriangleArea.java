import java.util.Scanner;


public class TriangleArea {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		System.out.print("Enter the coordinates of A: ");
		int Ax = scanner.nextInt();
		int Ay = scanner.nextInt();
		System.out.print("Enter the coordinates of B: ");
		int Bx = scanner.nextInt();
		int By = scanner.nextInt();		
		System.out.print("Enter the coordinates of C: ");
		int Cx = scanner.nextInt();
		int Cy = scanner.nextInt();
		
		int area = Math.abs((Ax * (By - Cy) + Bx * (Cy - Ay) + Cx * (Ay - By)) / 2);
		

		System.out.println("The area is: " + area);

	}
}

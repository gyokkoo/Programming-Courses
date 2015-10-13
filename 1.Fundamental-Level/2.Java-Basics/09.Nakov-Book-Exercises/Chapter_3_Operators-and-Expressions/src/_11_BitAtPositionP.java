import java.util.Scanner;

public class _11_BitAtPositionP {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		System.out.println("Enter a number.");
		int number = scanner.nextInt();
		System.out.println("Enter bit position.");
		int position = scanner.nextInt();
		
		System.out.println("The number in binary.");
		System.out.println(Integer.toBinaryString(number));
		int bit = (number >> position) & 1;
		System.out.println("The bit is: " + bit);
	}
}

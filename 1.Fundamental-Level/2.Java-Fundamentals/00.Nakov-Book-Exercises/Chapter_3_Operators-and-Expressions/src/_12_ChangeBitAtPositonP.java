import java.util.Scanner;

public class _12_ChangeBitAtPositonP {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		System.out.println("Enter a number.");
		int number = scanner.nextInt();
		System.out.println("Enter bit position.");
		int position = scanner.nextInt();
		System.out.println("Enter bit value (1 or 0).");
		int bitValue = scanner.nextInt();
		
		System.out.println("The number in binary.");
		System.out.println(Integer.toBinaryString(number));
		
		if(bitValue == 0) {
			int mask = ~(1 << position);
			number = number & mask;
		}
		else if(bitValue == 1) { 
			int mask = 1 << position;
			number = number | mask;
		}
		
		System.out.println("The new number in binary.");
		System.out.println(Integer.toBinaryString(number));
		System.out.println("The new number in decimal.");
		System.out.println(number);
	}
}

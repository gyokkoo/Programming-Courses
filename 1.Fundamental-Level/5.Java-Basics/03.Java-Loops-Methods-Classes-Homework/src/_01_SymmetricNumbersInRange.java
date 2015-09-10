import java.util.Scanner;

public class _01_SymmetricNumbersInRange {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int startRange = scanner.nextInt();
		int endRange = scanner.nextInt();
		
		printSymetricNumbersInRange(startRange, endRange);
	}

	private static void printSymetricNumbersInRange(int startRange, int endRange) {
		for (int i = startRange; i <= endRange; i++) {
			if(i <= 9) {
				System.out.print(i + " ");
			}
			else if(i >= 10 && i <= 99) {
				int units = i % 10;
				int tenths = i / 10 % 10;
				if(units == tenths) {
					System.out.print(i + " ");
				}
			}
			else if(i >= 100 && i <= 999) {
				int units = i % 10;
				int hundreds = i / 100 % 10;
				if(units == hundreds) {
					System.out.print(i + " ");
				}
			}
		}
	}
}

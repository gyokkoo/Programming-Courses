import java.util.Scanner;

public class _08_CountOfEqualBitPairs {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		System.out.print("n = ");
		int number = scanner.nextInt();
		System.out.println("Binary representation.");	
		System.out.println(Integer.toBinaryString(number).replace(' ', '0'));
		
		int equalBitPairsCoutner = 0;
		
		while(number != 0) {
			
			int currentBit = number & 1;
			int nextBit = (number >> 1) & 1;
			if(currentBit == nextBit) {
				equalBitPairsCoutner++;
			}
			number = number >> 1;
		}

		System.out.println("Count of equal bit pairs.");
		System.out.println(equalBitPairsCoutner);
	}
}

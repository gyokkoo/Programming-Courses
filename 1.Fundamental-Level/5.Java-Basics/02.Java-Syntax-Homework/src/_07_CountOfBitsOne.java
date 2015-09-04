import java.util.Scanner;

public class _07_CountOfBitsOne {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		System.out.print("n = ");
		int number = scanner.nextInt();
		System.out.println("Binary representation.");	
		System.out.println(String.format("%16s", Integer.toBinaryString(number)).replace(' ', '0'));
		
		int oneBitsCoutner = 0;
		
		while(number != 0) {
			if((number & 1) == 1) {
				oneBitsCoutner++;
			}
			number = number >> 1;
		}

		System.out.println("Count of bits one.");
		System.out.println(oneBitsCoutner);
	}
}

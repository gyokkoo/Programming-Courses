import java.util.Scanner;

public class _02_GenerateThreeLetterWords {
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		String inputString = scanner.nextLine();
		char[] chArray = inputString.toCharArray();
		
		for (int ch1 = 0; ch1 < chArray.length; ch1++) {
			for (int ch2 = 0; ch2 < chArray.length; ch2++) {
				for (int ch3 = 0; ch3 < chArray.length; ch3++) {
					System.out.printf("%c%c%c ", chArray[ch1], chArray[ch2], chArray[ch3]);
				}
			}
		}
	}
}

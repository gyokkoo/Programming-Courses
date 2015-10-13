
public class _10_SwapNumbers {
	public static void main(String[] args) {
		int firstNumber = 10;
		int secondNumber = 15;
		
		firstNumber = firstNumber + secondNumber;
		secondNumber = firstNumber - secondNumber;
		firstNumber = firstNumber - secondNumber;
		
		System.out.println("First number: " + firstNumber);
		System.out.println("Second number: " + secondNumber);
	}
}

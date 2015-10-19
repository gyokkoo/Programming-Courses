import java.util.Scanner;

public class _02_PlusOrMinus {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter two numbers.");
        double firstNumber = scanner.nextDouble();
        double secondNumber = scanner.nextDouble();
        String sign = null;

        if(firstNumber > 0 && secondNumber > 0 ||
            firstNumber < 0 && secondNumber < 0) {
            sign = "+";
        }
        else if(firstNumber > 0 && secondNumber < 0 ||
                firstNumber < 0 && secondNumber > 0) {
            sign = "-";
        }

        System.out.println("The sign in division is: " + sign);
    }
}

import java.util.Scanner;

public class _03_FindMax {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter three numbers.");
        int firstNumber = Math.abs(scanner.nextInt());
        int secondNumber = Math.abs(scanner.nextInt());
        int thirdNumber = Math.abs(scanner.nextInt());

        int maxNumber = Math.max(Math.max(firstNumber, secondNumber), thirdNumber);

        System.out.println("The biggest number by absolute value is: " + maxNumber);
    }
}

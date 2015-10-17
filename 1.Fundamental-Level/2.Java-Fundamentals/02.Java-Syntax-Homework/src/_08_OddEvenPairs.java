import java.util.Scanner;

public class _08_OddEvenPairs {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter an array of numbers in a single line.");
        String[] numbers = scanner.nextLine().split(" ");

        if(numbers.length % 2 == 0) {
            for (int i = 0; i < numbers.length - 1; i+=2) {
                int firstNumber = Integer.parseInt(numbers[i]);
                int secondNumber = Integer.parseInt(numbers[i + 1]);

                String pairType = getPairType(firstNumber, secondNumber);

                System.out.println(String.format("%d, %d -> %s",
                        firstNumber, secondNumber, pairType));
            }
        } else {
            System.out.println("Invalid length");
        }
    }

    private static String getPairType(int firstNumber, int secondNumber) {
        String pairType;
        if(firstNumber % 2 == 0 && secondNumber % 2 == 0) {
            pairType = "both are even";
        } else if(firstNumber % 2 == 1 && secondNumber % 2 == 1) {
            pairType = "both are odd";
        } else {
            pairType = "different";
        }

        return  pairType;
    }
}

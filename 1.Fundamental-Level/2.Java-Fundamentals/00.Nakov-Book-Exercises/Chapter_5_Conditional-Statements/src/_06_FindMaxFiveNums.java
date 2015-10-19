import java.util.Scanner;

public class _06_FindMaxFiveNums {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter five numbers.");
        int maxNumber = 0;
        for (int i = 0; i < 5; i++) {
            int currentNumber = Math.abs(scanner.nextInt());
            if(maxNumber < currentNumber) {
                maxNumber = currentNumber;
            }
        }
        System.out.println("Tha biggest number by absolute value is: " + maxNumber);
    }
}

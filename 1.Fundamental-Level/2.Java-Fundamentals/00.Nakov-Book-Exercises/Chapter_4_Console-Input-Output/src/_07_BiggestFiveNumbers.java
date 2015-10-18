import java.util.Scanner;

public class _07_BiggestFiveNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter five numbers.");
        int biggestNumber = Integer.MIN_VALUE;
        for (int i = 0; i < 5; i++) {
            int number = scanner.nextInt();
            if(biggestNumber < number) {
                biggestNumber = number;
            }
        }
        System.out.println("The biggest number is " + biggestNumber);
    }
}

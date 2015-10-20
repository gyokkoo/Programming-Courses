import java.util.Scanner;

public class _03_FindMaxMin {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter N = ");
        int n = scanner.nextInt();

        System.out.printf("Enter %d numbers.\n", n);
        int minNumber = Integer.MAX_VALUE;
        int maxNumber = Integer.MIN_VALUE;
        for (int i = 0; i < n; i++) {
            int curNumber = scanner.nextInt();
            if(minNumber > curNumber) {
                minNumber = curNumber;
            }
            if(maxNumber < curNumber) {
                maxNumber = curNumber;
            }
        }

        System.out.println("Max number is: " + maxNumber);
        System.out.println("Min number is: " + minNumber);

    }
}

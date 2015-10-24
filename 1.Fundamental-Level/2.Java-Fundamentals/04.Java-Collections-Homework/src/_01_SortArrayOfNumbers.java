import java.util.Arrays;
import java.util.Scanner;

public class _01_SortArrayOfNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a number n and n integer numbers.");
        System.out.print("n = ");
        int n = Integer.parseInt(scanner.nextLine());

        int[] arrayOfNumbers = new int[n];
        for (int i = 0; i < n; i++) {
            arrayOfNumbers[i] = scanner.nextInt();
        }

        Arrays.sort(arrayOfNumbers);

//        for (int number : arrayOfNumbers) {
//            System.out.println(number + " ");
//        }

        System.out.println(Arrays.toString(arrayOfNumbers));
    }
}

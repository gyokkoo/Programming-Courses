import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;

public class _04_LongestIncreasingSeq {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter integers in a single line, separated by a space.");
        String[] inputLineArr = scanner.nextLine().split(" ");
        int[] arrayOfNumbers = new int[inputLineArr.length];
        for (int i = 0; i < arrayOfNumbers.length; i++) {
            arrayOfNumbers[i] = Integer.parseInt(inputLineArr[i]);
        }

        int longestSeq = 0;
        int startIndex = 0;

        for (int i = 0; i < arrayOfNumbers.length; i++) {
            int currentNumber = arrayOfNumbers[i];
            int currentLongestSeq = 1;
            int currentIndex = i;

            System.out.print(currentNumber + " ");

            for (int j = i + 1; j < arrayOfNumbers.length; j++) {
                int tempNumber = arrayOfNumbers[j];
                if(tempNumber > currentNumber) {
                    System.out.print(tempNumber + " ");
                    currentNumber = tempNumber;
                    currentLongestSeq++;
                    i++;
                } else {
                    break;
                }
            }

            if(currentLongestSeq > longestSeq) {
                longestSeq = currentLongestSeq;
                startIndex = currentIndex;
            }
            System.out.println();
        }

        System.out.print("Longest: ");
        for (int i = startIndex; i < startIndex + longestSeq; i++) {
            System.out.print(arrayOfNumbers[i] + " ");
        }
    }
}

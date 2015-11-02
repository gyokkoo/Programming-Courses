import java.util.Arrays;
import java.util.Scanner;

public class _3_LongestOddEvenSequence {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String inputLine = scanner.nextLine();
        inputLine = inputLine.replaceAll("\\s+", "");
        inputLine = inputLine.substring(1, inputLine.length() - 1);
        String[] arr = inputLine.split("\\)\\(");
        int[] numbers = new int[arr.length];
        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = Math.abs(Integer.parseInt(arr[i]));
        }

        int maxSeq = 1;
        int curSeq = 1;
        for (int i = 1; i < numbers.length; i++) {
            if(numbers[i - 1] % 2 == 0 && numbers[i] == 0) {
                numbers[i] = 1;
            } else if(numbers[i - 1] % 2 == 1 && numbers[i] == 0) {
                numbers[i] = 2;
            }

            if((numbers[i - 1] % 2 == 0 && numbers[i] % 2 == 1) ||
                    (numbers[i - 1] % 2 == 1 && numbers[i] % 2 == 0)) {
                curSeq++;
            } else {
                curSeq = 1;
            }
            if(maxSeq < curSeq) {
                maxSeq = curSeq;
            }
        }

        System.out.println(maxSeq);
    }
}

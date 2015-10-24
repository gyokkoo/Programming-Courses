import java.util.Scanner;

public class _03_LargestSeqEqualStrings {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter an array of strings.");
        String inputLine = scanner.nextLine();
        String[] strArray = inputLine.split(" ");

        String largestStrElement = strArray[0];
        int longestSeqLength = 1;
        int currentLength = 1;
        for (int i = 1; i < strArray.length; i++) {
            if (strArray[i].equals(strArray[i - 1])) {
                currentLength++;
            } else {
                currentLength = 1;
            }

            if (longestSeqLength < currentLength) {
                longestSeqLength = currentLength;
                largestStrElement = strArray[i - 1];
            }
        }

        for (int i = 0; i < longestSeqLength; i++) {
            System.out.print(largestStrElement + " ");
        }
    }
}

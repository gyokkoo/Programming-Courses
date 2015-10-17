import java.util.Scanner;

public class _12_CharacterMultiplier {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter two strings.");
        String firstStr = scanner.next();
        String secondStr = scanner.next();

        int characterSum = calculateCharacterSum(firstStr, secondStr);

        System.out.println(characterSum);
    }

    private static int calculateCharacterSum(String firstStr, String secondStr) {
        int sum = 0;
        int firstStrLength = firstStr.length();
        int secondStrLength = secondStr.length();

        if(firstStrLength < secondStrLength) {
            for (int i = firstStrLength - 1; i < secondStrLength - firstStrLength; i++) {
                sum += secondStr.charAt(i);
            }
        } else if(firstStrLength > secondStrLength) {
            for (int i = secondStrLength - 1; i < firstStrLength - secondStrLength; i++) {
                sum += firstStr.charAt(i);
            }
        }

        for (int i = 0; i < Math.min(firstStrLength, secondStrLength); i++) {
            sum += firstStr.charAt(i) * secondStr.charAt(i);
        }

        return sum;
    }
}

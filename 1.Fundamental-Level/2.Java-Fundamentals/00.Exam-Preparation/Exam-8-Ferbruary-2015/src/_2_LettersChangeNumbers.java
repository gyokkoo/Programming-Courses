import java.util.Scanner;


public class _2_LettersChangeNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] numLetters = scanner.nextLine().replaceAll("\\s+", " ").split(" ");

        double resultSum = 0;
        for (String numLetter : numLetters) {
            char firstLetter = numLetter.charAt(0);
            char lastLetter = numLetter.charAt(numLetter.length() - 1);
            double number = Double.parseDouble(numLetter.substring(1, numLetter.length() - 1));

            if (Character.isLowerCase(firstLetter)) {
                number *= (firstLetter - 96);
            } else {
                number /= (firstLetter - 64);
            }

            if (Character.isLowerCase(lastLetter)) {
                number += (lastLetter - 96);
            } else {
                number -= (lastLetter - 64);
            }

            resultSum += number;
        }

        System.out.printf("%.2f", resultSum);
    }
}

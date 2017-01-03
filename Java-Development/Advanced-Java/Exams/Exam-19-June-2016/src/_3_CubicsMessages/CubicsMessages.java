package _3_CubicsMessages;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class CubicsMessages {

    private static final String END_MESSAGE = "Over!";

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Pattern pattern = Pattern.compile("^([\\d]+)([A-Za-z]+)([^A-Za-z]*)$");
        while (true) {
            String message = scanner.nextLine();
            if (END_MESSAGE.equals(message)) {
                break;
            }

            int number = Integer.parseInt(scanner.nextLine());
            Matcher matcher = pattern.matcher(message);
            while (matcher.find()) {
                String leftPart = matcher.group(1);
                String validMessage = matcher.group(2);
                String rightPart = matcher.group(3);
                if (validMessage.length() != number) {
                    continue;
                }

                String verificationCode = getVerificationCode(validMessage, leftPart);
                verificationCode += getVerificationCode(validMessage, rightPart);

                System.out.printf("%s == %s%n", validMessage, verificationCode);
            }
        }
    }

    private static String getVerificationCode(String validMessage, String str) {
        String result = "";
        for (int i = 0; i < str.length(); i++) {
            if (Character.isDigit(str.charAt(i))) {
                int index = Integer.parseInt(str.charAt(i) + "");
                if (0 <= index && index < validMessage.length()) {
                    result += validMessage.charAt(index);
                    continue;
                }
            }

            result += " ";
        }

        return result;
    }
}

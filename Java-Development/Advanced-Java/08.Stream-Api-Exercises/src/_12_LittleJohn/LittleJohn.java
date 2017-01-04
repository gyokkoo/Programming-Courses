package _12_LittleJohn;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class LittleJohn {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String arrows = "";
        for (int i = 0; i < 4; i++) {
            arrows += " " + scanner.nextLine();
        }

        Pattern pattern = Pattern.compile("(>>>----->>)|(>>----->)|(>----->)");
        Matcher matcher = pattern.matcher(arrows);

        int largeArrowCount = 0;
        int mediumArrowCount = 0;
        int smallArrowCount = 0;
        while (matcher.find()) {
            if (matcher.group(1) != null) {
                largeArrowCount++;
            }

            if (matcher.group(2) != null) {
                mediumArrowCount++;
            }

            if (matcher.group(3) != null) {
                smallArrowCount++;
            }
        }

        String numberAsString = smallArrowCount + "" + mediumArrowCount + largeArrowCount;
        Long number = Long.parseLong(numberAsString);

        String binaryNum = Long.toBinaryString(number);

        String reversedBinaryNum = new StringBuilder(binaryNum).reverse().toString();

        String resultAsString = binaryNum + reversedBinaryNum;

        long result = Long.parseLong(resultAsString, 2);

        System.out.println(result);
    }
}

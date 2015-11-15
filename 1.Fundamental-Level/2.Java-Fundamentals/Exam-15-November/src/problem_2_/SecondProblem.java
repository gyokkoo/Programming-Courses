package problem_2_;

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class SecondProblem {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String line = scanner.nextLine();
        double totalLiters = 0;
        boolean isFound = false;

        while(!line.equals("OK KoftiShans")) {
            Pattern pattern = Pattern.compile(".*?([A-Z][a-z]+).*?([A-Z][a-z]*[A-Z]).*?([0-9]+)L{1,100}");
            Matcher matcher = pattern.matcher(line);
            while (matcher.find()) {
                String guest = matcher.group(1);
                double quantity = Double.parseDouble(matcher.group(3).replaceAll("L", ""));
                String drink = matcher.group(2);
                totalLiters += quantity / 1000.0;
                System.out.printf("%s brought %d liters of %s!\n", guest, (int)quantity, drink.toLowerCase());
                isFound = true;
            }

            line = scanner.nextLine();
        }
        if(isFound) {
            System.out.printf("%.3f softuni liters\n",  totalLiters);
        }

    }
}

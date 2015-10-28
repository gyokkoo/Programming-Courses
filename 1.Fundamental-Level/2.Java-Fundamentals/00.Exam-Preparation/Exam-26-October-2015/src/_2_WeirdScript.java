import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _2_WeirdScript {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int keyNumber = Integer.parseInt(scanner.nextLine()) % 52;
        if (keyNumber >= 1 && keyNumber <= 26) {
            keyNumber += 96;
        } else if(keyNumber == 0) {
            keyNumber = 90;
        }
        else {
            keyNumber += 38;
        }
        String keyLetters = (char)keyNumber + "" + (char)keyNumber;

        StringBuilder text = new StringBuilder();
        String line = scanner.nextLine();
        while(!line.equals("End")) {
            text.append(line);
            line = scanner.nextLine();
        }

        String patternStr = keyLetters + "(.*?)" + keyLetters;
        Pattern pattern = Pattern.compile(patternStr);
        Matcher matcher = pattern.matcher(text.toString());
        while(matcher.find()) {
            System.out.println(matcher.group(1));
        }
    }
}

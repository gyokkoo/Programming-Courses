import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _2_TerroristsWin {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();
        text = text.replace("||", "..");
        Pattern pattern = Pattern.compile("\\|([^|]+)\\|");
        Matcher matcher = pattern.matcher(text);

        int endIndex = -1;
        while(matcher.find()) {
            int startIndex = text.indexOf("|", endIndex + 1);
            endIndex = text.indexOf("|", startIndex + 1);

            int bombPower = getBombPower(matcher.group(1));
            int start = startIndex - bombPower < 0 ? 0 : startIndex - bombPower;
            int end = endIndex + bombPower + 1 >= text.length() ? text.length() : endIndex + bombPower + 1;
            String replacement = text.substring(start, end);

            text = text.replace(replacement, newString('.', replacement.length()));
        }

        System.out.println(text);
    }

    private static CharSequence newString(char c, int length) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < length; i++) {
            sb.append(c);
        }
        return sb.toString();
    }

    private static int getBombPower(String str) {
        int sum = 0;
        for (int i = 0; i < str.length(); i++) {
            sum += str.charAt(i);
        }
        return sum % 10;
    }
}

import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _08_ExtractEmails {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter some text on a single line.");
        String text = scanner.nextLine().trim();

        Pattern emailPattern = Pattern.compile("[\\w\\.-_]+@[\\w\\.\\w]+\\w");
        Matcher emailMatcher = emailPattern.matcher(text);

        while(emailMatcher.find()) {
            System.out.println(emailMatcher.group());
        }
    }
}

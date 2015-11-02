import java.util.ArrayList;
import java.util.HashSet;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _1_CognateWords {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String text = scanner.nextLine();
        ArrayList<String> words = new ArrayList<>();

        Pattern pattern = Pattern.compile("[a-zA-Z]+");
        Matcher matcher = pattern.matcher(text);
        while(matcher.find()) {
            words.add(matcher.group());
        }

        HashSet<String> cognateWords = new HashSet<>();
        boolean isFound = false;
        for (String a : words) {
            for (String b : words) {
                for (String c : words) {
                    if(a.concat(b).equals(c)) {
                        cognateWords.add(String.format("%s|%s=%s", a, b, c));
                    }
                }
            }
        }

        if(cognateWords.isEmpty()) {
            System.out.println("No");
        } else {
            for (String cognateWord : cognateWords) {
                System.out.println(cognateWord);
            }
        }
    }
}

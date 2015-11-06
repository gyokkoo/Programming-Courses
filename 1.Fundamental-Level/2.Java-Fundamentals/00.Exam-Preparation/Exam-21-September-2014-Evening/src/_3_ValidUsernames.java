import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _3_ValidUsernames {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] userNames = scanner.nextLine().split("[\\s+\\/\\\\(\\)]");
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < userNames.length; i++) {
            sb.append(" " + userNames[i] + " ");
        }

        List<String> validUserNames = new ArrayList<>();
        Pattern pattern = Pattern.compile("\\s[a-zA-Z][\\w_]{2,25}\\b");
        Matcher matcher = pattern.matcher(sb.toString());
        while(matcher.find()) {
            validUserNames.add(matcher.group());
        }

        int maxLength = 0;
        int index = 0;
        for (int i = 0; i < validUserNames.size() - 1; i++) {
            int currentLength = validUserNames.get(i).trim().length() + validUserNames.get(i+1).trim().length();
            if(maxLength < currentLength) {
                maxLength = currentLength;
                index = i;
            }
        }
        System.out.println(validUserNames.get(index).trim());
        System.out.println(validUserNames.get(index + 1).trim());
    }
}

import java.util.HashMap;
import java.util.Scanner;

public class _14_ExchangeableWords {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter two strings.");
        String firstStr = scanner.next();
        String secondStr = scanner.next();

        Boolean isExchangeable;
        if(firstStr.length() == secondStr.length()) {
            isExchangeable = checkIsExchangeable(firstStr, secondStr);
        } else {
            isExchangeable = false;
        }

        System.out.println(isExchangeable);
    }

    private static Boolean checkIsExchangeable(String firstStr, String secondStr) {
        HashMap<Character, Character> dictionary = new HashMap<>();
        for (int i = 0; i < firstStr.length(); i++) {
            if (dictionary.containsKey(firstStr.charAt(i))) {
                if (secondStr.charAt(i) != dictionary.get(firstStr.charAt(i))) {
                    return false;
                }
            } else if (dictionary.containsValue(secondStr.charAt(i))) {
                return false;
            } else {
                dictionary.put(firstStr.charAt(i), secondStr.charAt(i));
            }
        }
        return true;
    }
}

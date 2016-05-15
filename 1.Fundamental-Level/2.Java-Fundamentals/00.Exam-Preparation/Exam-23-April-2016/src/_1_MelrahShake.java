import java.util.Scanner;

public class _1_MelrahShake {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();
        String pattern = scanner.nextLine();

        while (!pattern.isEmpty()) {
            if (text.contains(pattern)) {
                int startIndex = text.indexOf(pattern);
                int endIndex = startIndex + pattern.length();

                text = new StringBuilder(text).delete(startIndex, endIndex).toString();
                if (text.contains(pattern)) {
                    startIndex = text.lastIndexOf(pattern);
                    endIndex = startIndex + pattern.length();

                    text = new StringBuilder(text).delete(startIndex, endIndex).toString();
                    System.out.println("Shaked it.");
                } else {
                    break;
                }
            } else {
                break;
            }

            int index = pattern.length() / 2;
            pattern = new StringBuilder(pattern).deleteCharAt(index).toString();
        }

        System.out.println("No shake.");
        System.out.println(text);
    }
}
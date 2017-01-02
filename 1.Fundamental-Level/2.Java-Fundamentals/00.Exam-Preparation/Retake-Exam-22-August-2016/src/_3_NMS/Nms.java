package _3_NMS;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Nms {

    private static final String END_MESSAGE = "---NMS SEND---";

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        List<String> messages = new ArrayList<>();
        StringBuilder letters = new StringBuilder();
        String line = scanner.nextLine();
        while (!END_MESSAGE.equals(line)) {
            letters.append(line);
            line = scanner.nextLine();
        }

        StringBuilder sb = new StringBuilder();
        sb.append(letters.charAt(0));
        for (int i = 1; i < letters.length(); i++) {
            if (letters.toString().toLowerCase().charAt(i - 1) <=
                    letters.toString().toLowerCase().charAt(i)) {
                sb.append(letters.charAt(i));
            } else {
                messages.add(sb.toString());
                sb.setLength(0);
                sb.append(letters.charAt(i));
            }
        }

        messages.add(sb.toString());

        String delimeter = scanner.nextLine();
        System.out.println(String.join(delimeter, messages));
    }
}

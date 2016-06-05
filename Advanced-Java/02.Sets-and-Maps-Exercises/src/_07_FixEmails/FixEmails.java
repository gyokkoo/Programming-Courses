package _07_FixEmails;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class FixEmails {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        LinkedHashMap<String, String> emails = new LinkedHashMap<>();
        String line = scanner.nextLine();
        while (!"stop".equals(line)) {
            String name = line;
            String email = scanner.nextLine();
            if (!email.toLowerCase().endsWith(".uk") &&
                    !email.toLowerCase().endsWith(".us")) {
                emails.put(name, email);
            }

            line = scanner.nextLine();
        }

        for (Map.Entry<String, String> emailEntry : emails.entrySet()) {
            System.out.printf("%s -> %s%n", emailEntry.getKey(), emailEntry.getValue());
        }
    }
}
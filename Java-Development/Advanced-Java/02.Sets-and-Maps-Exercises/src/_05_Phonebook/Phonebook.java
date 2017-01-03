package _05_Phonebook;

import java.util.HashMap;
import java.util.Scanner;

public class Phonebook {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine();

        HashMap<String, String> phoneBook = new HashMap<>();
        while (!"search".equals(line)) {
            String[] lineArgs = line.split("-");
            String name = lineArgs[0];
            String phone = lineArgs[1];
            phoneBook.put(name, phone);

            line = scanner.nextLine();
        }

        line = scanner.nextLine();
        while (!"stop".equals(line)) {
            String nameToSearch = line;
            if (phoneBook.containsKey(nameToSearch)) {
                System.out.printf("%s -> %s%n", nameToSearch, phoneBook.get(nameToSearch));
            } else {
                System.out.printf("Contact %s does not exist.%n", nameToSearch);
            }

            line = scanner.nextLine();
        }
    }
}
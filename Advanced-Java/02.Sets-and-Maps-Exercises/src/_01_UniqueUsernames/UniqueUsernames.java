package _01_UniqueUsernames;

import java.util.LinkedHashSet;
import java.util.Scanner;

public class UniqueUsernames {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int countOfUserNames = scanner.nextInt();

        LinkedHashSet<String> userNames = new LinkedHashSet<>();
        for (int i = 0; i < countOfUserNames; i++) {
            String userName = scanner.next();
            userNames.add(userName);
        }

        userNames.forEach(System.out::println);
    }
}

package interfacesAndAbstraction._04_Telephony;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Smartphone smartphone = new Smartphone();

        String[] phoneNumbers = scanner.nextLine().split(" ");
        String[] sitesToVisit = scanner.nextLine().split(" ");

        for (String phoneNumber : phoneNumbers) {
            try {
                smartphone.callOtherPhone(phoneNumber);
            } catch (IllegalArgumentException e) {
                System.out.println(e.getMessage());
            }
        }

        for (String site : sitesToVisit) {
            try {
                smartphone.browseInWeb(site);
            } catch (IllegalArgumentException e) {
                System.out.println(e.getMessage());
            }
        }
    }
}

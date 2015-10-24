import java.util.Scanner;

public class _02_SequenceEqualStrings {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter an array of strings.");
        String inputLine = scanner.nextLine();
        String[] strArray = inputLine.split(" ");

        for (int i = 0; i < strArray.length - 1; i++) {
           if(strArray[i].equals(strArray[i + 1])) {
               System.out.print(strArray[i] + " ");
           } else {
               System.out.println(strArray[i] + " ");
           }
        }
        System.out.println(strArray[strArray.length - 1]);
    }
}

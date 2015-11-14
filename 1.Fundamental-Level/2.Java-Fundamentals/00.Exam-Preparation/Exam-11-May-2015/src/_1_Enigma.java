import java.util.Scanner;

public class _1_Enigma {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        for (int i = 0; i < n; i++) {
            String line = scanner.nextLine();
            char[] charArr = line.toCharArray();
            int lineLength = line.replaceAll("\\d*\\s*", "").length();
            for (int j = 0; j < charArr.length; j++) {
                if(!Character.isDigit(charArr[j]) && charArr[j] != ' ') {
                    charArr[j] = (char)(charArr[j] + lineLength/2);
                }
            }

            for (int j = 0; j < charArr.length; j++) {
                System.out.print(charArr[j]);
            }
            System.out.println();
        }
    }
}

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class _07_GhettoNumeralSystem {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter a number");
        int number = scanner.nextInt();
        List<String> ghettoNumbersList = new ArrayList<String>();

        while(number > 0)
        {
            int lastDigit = number % 10;
            String ghettoNumber = getGhettoNumber(lastDigit);
            ghettoNumbersList.add(ghettoNumber);
            number = number / 10;
        }

        System.out.println("The number in ghetto numeral system is:");
        for (int i = ghettoNumbersList.size() - 1; i >= 0; i--) {
            System.out.print(ghettoNumbersList.get(i));
        }
        System.out.println();

    }

    private static String getGhettoNumber(int digit) {
        String[] ghettoNumbersArray = {"Gee", "Bro", "Zuz",
                                        "Ma", "Duh", "Yo",
                                        "Dis", "Hood", "Jam", "Mack"};

        String ghettoNumber = ghettoNumbersArray[digit];

        return ghettoNumber;
    }
}

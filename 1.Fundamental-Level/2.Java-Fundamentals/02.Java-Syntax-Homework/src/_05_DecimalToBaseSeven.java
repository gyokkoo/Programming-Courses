import java.util.Scanner;

public class _05_DecimalToBaseSeven {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a number.");
        int number = scanner.nextInt();

        String baseSevenNumber = Integer.toString(number, 7);
        System.out.println("The number in base-7 is: " + baseSevenNumber);
    }
}

import java.util.Scanner;

public class _04_PrintDigit {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a number [0-9]");
        int number = scanner.nextInt();
        int digit = number % 10;

        System.out.println(getLastDigit(digit));
    }

    private static String getLastDigit(int digit) {
        switch(digit){
            case 0:
                return "Zero";
            case 1:
                return "One";
            case 2:
                return "Two";
            case 3:
                return "Three";
            case 4:
                return "Four";
            case 5:
                return "Five";
            case 6:
                return "Six";
            case 7:
                return "Seven";
            case 8:
                return "Eight";
            case 9:
                return "Nine";
            default:
                return "From 1 to 9 genius!";
        }
    }
}

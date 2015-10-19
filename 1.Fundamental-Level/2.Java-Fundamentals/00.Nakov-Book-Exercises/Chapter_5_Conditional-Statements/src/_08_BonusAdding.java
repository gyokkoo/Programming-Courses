import java.util.Scanner;

public class _08_BonusAdding {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a number [0-9]");
        int number = scanner.nextInt();

        switch (number) {
            case 1: number *= 10; break;
            case 2: number *= 10; break;
            case 3: number *= 10; break;
            case 4: number *= 100; break;
            case 5: number *= 100; break;
            case 6: number *= 100; break;
            case 7: number *= 1000; break;
            case 8: number *= 1000; break;
            case 9: number *= 1000; break;
            default:
                System.out.println("I said number in range [0-9] !");
        }

        System.out.println(number);
    }
}

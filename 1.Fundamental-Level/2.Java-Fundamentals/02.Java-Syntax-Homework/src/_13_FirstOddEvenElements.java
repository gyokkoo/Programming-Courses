import java.util.ArrayList;
import java.util.Scanner;

public class _13_FirstOddEvenElements {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] strNumbers = scanner.nextLine().split(" ");

        ArrayList<Integer> evenNumbers = new ArrayList<>();
        ArrayList<Integer> oddNumbers = new ArrayList<>();

        int[] numbers = new int[strNumbers.length];
        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = Integer.parseInt(strNumbers[i]);
            if(numbers[i] % 2 == 0) {
                evenNumbers.add(numbers[i]);
            } else {
                oddNumbers.add(numbers[i]);
            }
        }

        String[] commandsArgs = scanner.nextLine().split(" ");
        if(commandsArgs[2].equals("even")) {
            int count = Integer.parseInt(commandsArgs[1]);
            count = count > evenNumbers.size() ? evenNumbers.size(): count;

            for (int i = 0; i < count; i++) {
                System.out.print(evenNumbers.get(i) + " ");
            }
        } else if(commandsArgs[2].equals("odd")) {
            int count = Integer.parseInt(commandsArgs[1]);
            count = count > oddNumbers.size() ? oddNumbers.size(): count;

            for (int i = 0; i < count; i++) {
                System.out.print(oddNumbers.get(i) + " ");
            }
        }
    }
}

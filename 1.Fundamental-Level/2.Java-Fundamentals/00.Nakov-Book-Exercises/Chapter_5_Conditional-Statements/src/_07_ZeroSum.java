import java.util.ArrayList;
import java.util.Scanner;

public class _07_ZeroSum {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter sequence of numbers and enter END");
        ArrayList<Integer> numbers = new ArrayList<>();
        while(scanner.hasNextInt()) {
            numbers.add(scanner.nextInt());
        }

        boolean isFound = false;
        for (int i = 0; i < numbers.size(); i++) {
            for (int j = i; j < numbers.size(); j++) {
                if(numbers.get(i) + numbers.get(j) == 0) {
                    System.out.println(numbers.get(i) + " + " + numbers.get(j) + " = 0");
                    isFound = true;
                }
            }
        }
        if(!isFound) {
            System.out.println("Not found numbers with sum 0");
        }
    }
}

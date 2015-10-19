import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class _3_BiggestThreePrime {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();
        text = text.replaceAll("\\s+", " ");

        String[] numbersArray = text.split("[( )]+");
        ArrayList<Integer> primeNumbers = new ArrayList<>();
        for (int i = 0; i < numbersArray.length; i++) {
            try {
                int number = Integer.parseInt(numbersArray[i]);
                if(isPrime(number) && !primeNumbers.contains(number)) {
                    primeNumbers.add(number);
                }
            } catch (Exception e) {
                continue;
            }
        }

        if(primeNumbers.size() >= 3) {
            int sum = 0;
            Collections.sort(primeNumbers);
            for (int i = primeNumbers.size() - 1; i >= primeNumbers.size() - 3; i--) {
                sum += primeNumbers.get(i);
            }
            System.out.println(sum);
        } else {
            System.out.println("No");
        }
    }

    private static boolean isPrime(int number) {
        if(number <= 1) {
            return false;
        }
        for (int i = 2; i <= Math.sqrt(number); i++) {
            if(number % i == 0) {
                return false;
            }
        }
        return true;
    }
}

import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

public class _07_RandomizeNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter two integers.");
        int n = scanner.nextInt();
        int m = scanner.nextInt();

        int min = Math.min(n, m);
        int max = Math.max(n, m);

        ArrayList<Integer> numbersList = new ArrayList<>();
        for (int i = min; i <= max; i++) {
            numbersList.add(i);
        }

        Random rnd = new Random();
        int size = numbersList.size();
        while(size > 0) {
            int randomIndex = rnd.nextInt(size);
            System.out.print(numbersList.remove(randomIndex) + " ");
            size--;
        }
    }
}

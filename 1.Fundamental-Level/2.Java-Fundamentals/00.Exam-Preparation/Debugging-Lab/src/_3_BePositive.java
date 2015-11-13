import java.util.ArrayList;
import java.util.Scanner;

public class _3_BePositive {
    public static void main(String[] args) {
        Scanner scn = new Scanner(System.in);

        int countSequences = Integer.parseInt(scn.nextLine());

        int lastNumber;
        for (int i = 0; i < countSequences; i++) {
            String[] input = scn.nextLine().replaceAll("\\s+"," ").trim().split(" ");
            ArrayList<Integer> numbers = new ArrayList<>();

            for (int j = 0; j < input.length; j++) {
                int num = Integer.parseInt(input[j]);
                numbers.add(num);
            }

            boolean found = false;
            for (int j = 0; j < numbers.size(); j++) {
                int currentNum = numbers.get(j);

                if (currentNum >= 0) {
                    System.out.printf("%d%s", currentNum, j == numbers.size() - 1 ? "\n" : " ");
                    found = true;
                } else {
                    if(j + 1 < numbers.size()) {
                        currentNum += numbers.get(j + 1);
                        if (currentNum >= 0) {
                            System.out.printf("%d%s", currentNum, j == numbers.size() - 2 ? "\n" : " ");
                            found = true;
                        }
                    } else {
                        break;
                    }
                    j++;
                }
            }

            if (!found) {
                System.out.println("(empty)");
            }
        }
    }
}

import java.util.ArrayList;
import java.util.Scanner;

public class _2_MagicSum {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int d = Integer.parseInt(scanner.nextLine());
        String inputLine = scanner.nextLine();
        ArrayList<Integer> numbers = new ArrayList<>();
        while(!inputLine.equals("End")) {
            int num = Integer.parseInt(inputLine);
            numbers.add(num);
            inputLine = scanner.nextLine();
        }

        boolean isFound = false;
        int maxSum = Integer.MIN_VALUE;
        int a=0,b=0,c=0;
        for (int i = 0; i < numbers.size(); i++) {
            for (int j = 0; j < numbers.size(); j++) {
                for (int k = 0; k < numbers.size(); k++) {
                    int sum = numbers.get(i) + numbers.get(j) + numbers.get(k);
                    if(sum % d == 0 && i != k && i != j && k != j   ) {
                        if(maxSum < sum) {
                            maxSum = sum;
                            isFound = true;
                            a = i;
                            b = j;
                            c = k;
                        }
                    }
                }
            }
        }

        if(!isFound) {
            System.out.println("No");
        } else {
            System.out.printf("(%d + %d + %d) %% %d = 0",
                    numbers.get(a),numbers.get(b), numbers.get(c), d);
        }
    }
}

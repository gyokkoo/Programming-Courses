import java.util.ArrayList;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _3_LargestThreeRectangles {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String inputLine = scanner.nextLine();
        ArrayList<Integer> sides = new ArrayList<>();

        Pattern pattern = Pattern.compile("\\[\\s*(\\d+)\\s*x\\s*(\\d+)\\s*\\]");
        Matcher matcher = pattern.matcher(inputLine);
        while(matcher.find()) {
//            System.out.println(matcher.group(1));
//            System.out.println(matcher.group(2));
            sides.add(Integer.parseInt(matcher.group(1)));
            sides.add(Integer.parseInt(matcher.group(2)));
        }

        int maxSum = Integer.MIN_VALUE;

        for (int i = 0; i < sides.size() - 5; i += 2) {
            int curSum = sides.get(i) * sides.get(i + 1) +
                    sides.get(i + 2) * sides.get(i + 3) +
                    sides.get(i + 4) * sides.get(i + 5);
            if (maxSum < curSum) {
                maxSum = curSum;
            }
        }

        System.out.println(maxSum);
    }
}

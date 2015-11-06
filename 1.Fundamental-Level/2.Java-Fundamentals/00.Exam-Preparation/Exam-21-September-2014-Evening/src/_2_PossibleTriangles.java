import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class _2_PossibleTriangles {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String inputLine = scanner.nextLine();

        boolean isFound = false;
        while(!inputLine.equals("End")) {
            String[] nums = inputLine.split(" ");
            ArrayList<Double> listNums = new ArrayList<>();
            listNums.add(Double.parseDouble(nums[0]));
            listNums.add(Double.parseDouble(nums[1]));
            listNums.add(Double.parseDouble(nums[2]));
            Collections.sort(listNums);
            if(listNums.get(0) + listNums.get(1) > listNums.get(2)) {
                System.out.printf("%.2f+%.2f>%.2f\n",
                        listNums.get(0), listNums.get(1), listNums.get(2));
                isFound = true;
            }

            inputLine = scanner.nextLine();
        }

        if(!isFound) {
            System.out.println("No");
        }
    }
}

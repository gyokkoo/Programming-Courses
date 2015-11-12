import java.util.*;

public class _1_Pyramid {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        scanner.nextLine();

        int previousNum = scanner.nextInt();
        List<Integer> resultNums = new ArrayList<>();
        resultNums.add(previousNum);

        scanner.nextLine();

        for (int i = 1; i < n; i++) {
            String[] inputLine = scanner.nextLine().replaceAll("\\s+", " ").trim().split(" ");
            int[] numbers = new int[inputLine.length];

            for (int j = 0; j < numbers.length; j++) {
                numbers[j] = Integer.parseInt(inputLine[j]);
            }

            Arrays.sort(numbers);

            boolean isFound = false;
            for (int j = 0; j < numbers.length; j++) {
                int currentNum = numbers[j];
                if(previousNum < currentNum) {
                    previousNum = currentNum;
                    resultNums.add(currentNum);
                    isFound = true;
                    break;
                }
            }
            if(!isFound) {
                previousNum++;
            }
        }

        System.out.println(resultNums.toString().substring(1, resultNums.toString().length() - 1));
        
    }
}

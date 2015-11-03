import java.util.Scanner;

public class _3_WeirdStrings {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();
        text = text.replaceAll("[\\/\\|\\(\\)\\s]+", "");
        String[] words = text.split("[^a-zA-Z]+");

        int sum = 0;
        int index = 0;
        for (int i = 0; i < words.length - 1; i++) {
            int curSum = getSum((words[i]+words[i+1]).toLowerCase());
            if(curSum >= sum) {
                sum = curSum;
                index = i;
            }

        }
        System.out.println(words[index]);
        System.out.println(words[index + 1]);
    }

    private static int getSum(String str) {
        int sum = 0;
        for (int i = 0; i < str.length(); i++) {
            sum += str.charAt(i) - ('a'-1);
        }
        return sum;
    }
}

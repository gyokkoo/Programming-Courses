import java.util.Scanner;

public class _1_MirrorNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        String[] nums = scanner.nextLine().split(" ");

        boolean isFound = false;
        for (int i = 0; i < nums.length; i++) {
            for (int j = i; j < nums.length; j++) {
                if (nums[i].equals(reverseString(nums[j])) && !nums[i].equals(nums[j])) {
                    System.out.println(nums[i] + "<!>" + nums[j]);
                    isFound = true;
                }
            }
        }
        if(!isFound) {
            System.out.println("No");
        }
    }

    public static String reverseString(String str) {
        StringBuilder sb = new StringBuilder();
        for (int i = str.length() - 1; i >= 0; i--) {
            sb.append(str.charAt(i));
        }

        return sb.toString();
    }
}

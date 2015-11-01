import java.util.Scanner;

public class _2_PythagoreanNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        int[] nums = new int[n];
        for (int i = 0; i < n; i++) {
            nums[i] = Integer.parseInt(scanner.nextLine());
        }

        boolean isFound = false;
        for (int a = 0; a < n; a++) {
            for (int b = 0; b < n; b++) {
                for (int c = 0; c < n; c++) {
                    if((nums[a]*nums[a] + nums[b]*nums[b] == nums[c] *nums[c]) && (nums[a] <= nums[b])) {
                        System.out.printf("%d*%d + %d*%d = %d*%d\n",
                                nums[a], nums[a], nums[b], nums[b], nums[c], nums[c]);
                        isFound = true;
                    }
                }
            }
        }

        if(!isFound) {
            System.out.println("No");
        }
    }
}

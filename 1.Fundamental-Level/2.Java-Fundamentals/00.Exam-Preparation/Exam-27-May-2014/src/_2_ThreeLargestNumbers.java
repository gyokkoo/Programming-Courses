import java.math.BigDecimal;
import java.util.Arrays;
import java.util.Scanner;

public class _2_ThreeLargestNumbers {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());
        BigDecimal[] nums = new BigDecimal[n];
        for (int i = 0; i < n; i++) {
            nums[i] = new BigDecimal(scanner.nextLine());
        }
        Arrays.sort(nums);
        int lengthMinusThree = nums.length - 3 < 0 ? 0 : nums.length - 3;
        for (int i = nums.length - 1; i >= lengthMinusThree; i--) {
            System.out.println(nums[i].toPlainString());
        }
    }
}
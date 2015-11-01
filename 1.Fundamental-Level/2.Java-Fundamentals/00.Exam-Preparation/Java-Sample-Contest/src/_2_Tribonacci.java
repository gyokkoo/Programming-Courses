import java.math.BigInteger;
import java.util.Scanner;

public class _2_Tribonacci {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        BigInteger t1 = new BigInteger(scanner.nextLine());
        BigInteger t2 = new BigInteger(scanner.nextLine());
        BigInteger t3 = new BigInteger(scanner.nextLine());
        long n = Integer.parseInt(scanner.nextLine());

        BigInteger result = GetNthTribonacci(t1, t2, t3, n);

        System.out.println(result);
    }

    private static BigInteger GetNthTribonacci(BigInteger t1, BigInteger t2, BigInteger t3, long n) {
        if(n == 1) {
            return t1;
        } else if(n == 2) {
            return t2;
        } else if(n == 3) {
            return t3;
        } else {
            BigInteger result = new BigInteger("0");
            for (int i = 1; i <= n - 3; i++) {
                BigInteger sum = t1.add(t2).add(t3);
                result = sum;
                t1 = t2;
                t2 = t3;
                t3 = sum;
            }
            return result;
        }
    }
}

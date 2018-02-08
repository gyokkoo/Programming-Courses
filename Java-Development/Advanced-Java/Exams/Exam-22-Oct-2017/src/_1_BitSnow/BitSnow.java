package _1_BitSnow;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import static java.util.Arrays.stream;

public class BitSnow {
    private static final int BITS = 16;

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String lineInput = reader.readLine();
        int[] numbers =
                stream(lineInput.split((",\\s+")))
                .mapToInt(Integer::parseInt)
                .toArray();

        int[] masks = new int[BITS];
        int[] bitsCount = new int[BITS];
        for (int number : numbers) {
            for (int bit = 0; bit < BITS; bit++) {
                masks[bit] = 1 << bit;
                if ((number & masks[bit]) != 0) {
                    bitsCount[bit]++;
                }
            }
        }

        for (int i = numbers.length - 1; i >= 0; i--) {
            int number = 0;
            for (int bit = 0; bit < BITS; bit++) {
                if (bitsCount[bit] > 0) {
                    number |= masks[bit];
                    bitsCount[bit]--;
                }
            }
            numbers[i] = number;
        }

        for (int i = 0; i < numbers.length - 1; i++) {
            System.out.print(numbers[i] + ", ");
        }
        System.out.println(numbers[numbers.length - 1]);
    }

    // This method is slow
    private static void snowFlake(int[] numbers, int[] mask) {
        for (int i = numbers.length - 2; i >= 0; i--) {
            for (int k = 0; k < BITS; k++) {
                int lastBit = (numbers[i] & mask[k]) >> k;
                if (lastBit == 0) {
                    continue;
                }
                int nextNumberLastBit = (numbers[i + 1] & mask[k]) >> k;
                if (lastBit == 1 && nextNumberLastBit == 0) {
                    numbers[i] &= ~mask[k];
                    numbers[i + 1] |= mask[k];
                }
            }
        }
    }
}

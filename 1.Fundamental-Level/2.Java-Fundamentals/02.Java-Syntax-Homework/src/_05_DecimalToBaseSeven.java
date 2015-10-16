import java.util.Scanner;

public class _05_DecimalToBaseSeven {

    //https://www.youtube.com/watch?v=yxIGZ9wST_4 useful video about converting logic
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter a number.");
        int n = scanner.nextInt();
        int number = Math.abs(n);

        StringBuilder sb = new StringBuilder();
        int pow = 4;

        while(number > 0) {
            int sevenPow = (int)Math.pow(7, pow);
            int sevenBaseDigit = number / sevenPow;
            number = number % sevenPow;
            if(number < sevenPow) {
                pow--;
            }
            sb.append(sevenBaseDigit);
        }
        String baseSevenNumber = sb.toString().replaceFirst("^0*", "");

        baseSevenNumber = n < 0 ? ("-" + baseSevenNumber) : baseSevenNumber;
        System.out.println("The number in base-7 is: " + baseSevenNumber);

    }
}

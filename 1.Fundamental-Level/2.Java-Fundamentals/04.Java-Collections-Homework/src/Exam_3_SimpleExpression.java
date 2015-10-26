import java.math.BigDecimal;
import java.text.DecimalFormat;
import java.util.Scanner;
//https://judge.softuni.bg/Contests/Practice/Index/14#2

public class Exam_3_SimpleExpression {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String inputLine = scanner.nextLine();

        inputLine = inputLine.replaceAll("-", " - ");
        inputLine = inputLine.replaceAll("-\\s+", "-");
        inputLine = inputLine.replaceAll("\\+", " ");

        String[] expressions = inputLine.trim().split("\\s+");

        double sum = 0;
        for (String expression : expressions) {
            double number = Double.parseDouble(expression);
            sum += number;
        }
        BigDecimal bigDec = new BigDecimal(sum);
        String result = new DecimalFormat("0.0000000").format(bigDec);
        System.out.println(result);
    }
}
package staticMembers._07_BasicMath;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class BasicMathMain {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        while (true) {
            String[] tokens = reader.readLine().split(" ");
            if (tokens[0].equals("End")) {
                break;
            }

            String command = tokens[0];
            double firstNumber = Double.parseDouble(tokens[1]);
            double secondNumber = Double.parseDouble(tokens[2]);
            double result = 0;
            switch (command) {
                case "Sum":
                    result = MathUtil.sum(firstNumber, secondNumber);
                    break;
                case "Subtract":
                    result = MathUtil.subtract(firstNumber, secondNumber);
                    break;
                case "Multiply":
                    result = MathUtil.multiply(firstNumber, secondNumber);
                    break;
                case "Divide":
                    result = MathUtil.divide(firstNumber, secondNumber);
                    break;
                case "Percentage":
                    result = MathUtil.percentage(firstNumber, secondNumber);
                    break;
            }

            System.out.printf("%.2f%n", result);
        }
    }
}

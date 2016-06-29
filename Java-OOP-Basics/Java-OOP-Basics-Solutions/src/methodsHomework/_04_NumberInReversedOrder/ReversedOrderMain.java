package methodsHomework._04_NumberInReversedOrder;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class ReversedOrderMain {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        Double number = Double.valueOf(reader.readLine());
        DecimalNumber decimalNumber = new DecimalNumber(number);
        decimalNumber.printDigitsInReversedOrder();
    }
}

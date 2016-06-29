package methodsHomework._03_LastDigitName;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class LastDigitMain {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        Integer numberValue = Integer.valueOf(reader.readLine());
        Number number = new Number(numberValue);
        System.out.println(number.getLastDigitName());
    }
}

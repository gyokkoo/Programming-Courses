package reflection._02_BlackBoxInteger;

import reflection._02_BlackBoxInteger.com.peshoslav.BlackBoxInt;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.lang.reflect.Constructor;
import java.lang.reflect.Field;
import java.lang.reflect.Method;

public class Main {

    public static void main(String[] args) throws ReflectiveOperationException, IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        Class<BlackBoxInt> blackBoxIntClass = BlackBoxInt.class;
        Constructor<BlackBoxInt> ctor = blackBoxIntClass.getDeclaredConstructor();
        ctor.setAccessible(true);
        BlackBoxInt blackBoxInt = ctor.newInstance();
        while (true) {
            String[] commandTokens = reader.readLine().split("_");
            if (commandTokens[0].equals("END")) {
                break;
            }

            String methodName = commandTokens[0];
            int value = Integer.parseInt(commandTokens[1]);

            Method method = blackBoxIntClass.getDeclaredMethod(methodName, int.class);
            method.setAccessible(true);
            method.invoke(blackBoxInt, value);
            Field valueField = blackBoxInt.getClass().getDeclaredField("innerValue");
            valueField.setAccessible(true);
            System.out.println(valueField.get(blackBoxInt));
        }
    }
}
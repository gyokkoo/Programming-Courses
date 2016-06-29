package methodsHomework._06_PrimeChecker;

import com.sun.org.apache.bcel.internal.classfile.ClassFormatException;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.lang.reflect.Constructor;
import java.lang.reflect.Field;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class PrimeChecker {
    public static void main(String[] args) throws IOException {
        Field[] fields = Number.class.getDeclaredFields();

        List<Field> fieldsDeclared = Arrays.stream(fields)
                .filter(f -> f.getName().contains("prime") || f.getName().contains("number"))
                .collect(Collectors.toList());

        List<Constructor<?>> constructors = Arrays
                .stream(Number.class.getDeclaredConstructors())
                .filter(c -> c.getParameterCount() > 1)
                .collect(Collectors.toList());

        if (fieldsDeclared.size() <= 1 || constructors.size() < 1) {
            throw new ClassFormatException();
        }

        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        Integer n = Integer.valueOf(reader.readLine());
        Number number = new Number(n, false);
        System.out.printf("%d, %s%n", number.nextPrimeNumber().getNumber(), number.getPrime());
    }
}

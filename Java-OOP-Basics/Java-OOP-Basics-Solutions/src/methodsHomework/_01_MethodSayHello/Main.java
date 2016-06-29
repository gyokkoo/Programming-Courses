package methodsHomework._01_MethodSayHello;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.lang.reflect.Field;
import java.lang.reflect.Method;

public class Main {

    public static void main(String[] args) throws ClassNotFoundException, IOException {
        Field[] fields = Person.class.getDeclaredFields();
        Method[] methods = Person.class.getDeclaredMethods();
        if (fields.length != 1 || methods.length != 1) {
            throw new ClassFormatError();
        }

        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String name = reader.readLine();
        Person person = new Person(name);
        person.printHello();
    }
}

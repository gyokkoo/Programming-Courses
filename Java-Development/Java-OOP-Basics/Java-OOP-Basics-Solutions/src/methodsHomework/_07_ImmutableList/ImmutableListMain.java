package methodsHomework._07_ImmutableList;

import com.sun.org.apache.bcel.internal.classfile.ClassFormatException;

import java.lang.reflect.Field;
import java.lang.reflect.Method;

public class ImmutableListMain {

    public static void main(String[] args) {

        Class listClass = ImmutableList.class;
        Field[] fields = listClass.getDeclaredFields();
        if (fields.length < 1) {
            throw new ClassFormatException();
        }

        Method method = listClass.getDeclaredMethods()[0];
        System.out.println(method.getReturnType().getSimpleName());
    }
}

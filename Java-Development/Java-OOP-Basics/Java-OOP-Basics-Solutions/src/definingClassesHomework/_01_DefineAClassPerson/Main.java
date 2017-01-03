package definingClassesHomework._01_DefineAClassPerson;

import java.lang.reflect.Field;

public class Main {

    public static void main(String[] args) {
        Class person = Person.class;
        Field[] fields = person.getDeclaredFields();
        System.out.println(fields.length);

        Person pesho = new Person();
        pesho.name = "Pesho";
        pesho.age = 20;

        Person gosho = new Person();
        gosho.name = "Gosho";
        gosho.age = 18;

        Person stamat = new Person();
        stamat.name = "Stamat";
        stamat.age = 43;
    }
}

class Person {
    String name;
    int age;
}

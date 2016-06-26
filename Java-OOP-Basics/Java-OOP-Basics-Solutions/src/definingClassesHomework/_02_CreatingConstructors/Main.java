package definingClassesHomework._02_CreatingConstructors;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.lang.reflect.Constructor;

public class Main {

    public static void main(String[] args) throws Exception {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        Class personClass = Person.class;
        Constructor emptyCtor = personClass.getDeclaredConstructor();
        Constructor ageCtor = personClass.getDeclaredConstructor(int.class);
        Constructor nameAgeCtor = personClass.getDeclaredConstructor(String.class, int.class);

        String name = reader.readLine();
        int age = Integer.parseInt(reader.readLine());

        Person basePerson = (Person) emptyCtor.newInstance();
        Person personWithAge = (Person) ageCtor.newInstance(age);
        Person personFull = (Person) nameAgeCtor.newInstance(name, age);

        System.out.printf("%s %s%n", basePerson.name, basePerson.age);
        System.out.printf("%s %s%n", personWithAge.name, personWithAge.age);
        System.out.printf("%s %s%n", personFull.name, personFull.age);
    }
}

class Person {
    private static final String DEFAULT_NAME = "No name";

    String name;
    int age;

    public Person() {
        this(DEFAULT_NAME, 1);
    }

    public Person(int age) {
        this(DEFAULT_NAME, age);
    }

    public Person(String name, int age) {
        this.name = name;
        this.age = age;
    }
}
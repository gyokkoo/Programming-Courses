package definingClassesHomework._03_OpinionPoll;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.TreeSet;

public class OpinionPoll {
    private static final int MIN_AGE = 30;

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        TreeSet<Person> people = new TreeSet<>();
        int countOfPeople = Integer.parseInt(reader.readLine());
        for (int i = 0; i < countOfPeople; i++) {
            String[] tokens = reader.readLine().split(" ");
            String name = tokens[0];
            int age = Integer.parseInt(tokens[1]);
            Person person = new Person(name, age);
            people.add(person);
        }

        people.stream().filter(person -> person.getAge() > MIN_AGE).forEach(System.out::println);
    }
}
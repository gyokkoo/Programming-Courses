package definingClassesHomework._03_OpinionPoll;

public class Person implements Comparable<Person> {
    private String name;
    private int age;

    public Person(String name, int age) {
        this.name = name;
        this.age = age;
    }

    public int getAge() {
        return age;
    }

    public String getName() {
        return name;
    }

    @Override
    public String toString() {
        return String.format("%s - %d", this.name, this.age);
    }

    @Override
    public int compareTo(Person person) {
        return this.name.compareTo(person.getName());
    }
}
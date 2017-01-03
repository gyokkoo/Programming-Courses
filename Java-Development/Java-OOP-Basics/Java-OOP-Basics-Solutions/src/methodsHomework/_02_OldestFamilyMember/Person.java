package methodsHomework._02_OldestFamilyMember;

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

    @Override
    public String toString() {
        return this.name + " " + this.age;
    }

    @Override
    public int compareTo(Person person) {
        return Integer.compare(person.getAge(), this.getAge());
    }
}

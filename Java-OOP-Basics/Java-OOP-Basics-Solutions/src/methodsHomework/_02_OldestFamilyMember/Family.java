package methodsHomework._02_OldestFamilyMember;

import java.util.TreeSet;

public class Family {
    private TreeSet<Person> people;

    public Family() {
        this.people = new TreeSet<>();
    }

    public void addFamilyMember(Person member) {
        this.people.add(member);
    }


    public Person getOldestMember() {
        return people.first();
    }
}

package definingClassesHomework._10_FamilyTree;

import java.util.ArrayList;
import java.util.List;

public class Person {
    private String name;
    private String birthday;
    private List<Person> parents;
    private List<Person> children;

    public Person(String name, String birthday) {
        this.name = name;
        this.birthday = birthday;
    }

    public Person() {
        this.parents = new ArrayList<>();
        this.children = new ArrayList<>();
    }

    public void setName(String name) {
        this.name = name;
    }

    public void setBirthday(String birthday) {
        this.birthday = birthday;
    }
}

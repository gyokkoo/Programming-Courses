package interfacesAndAbstraction._02_MultipleImplementation;

import interfacesAndAbstraction._02_MultipleImplementation.interfaces.Birthable;
import interfacesAndAbstraction._02_MultipleImplementation.interfaces.Identifiable;
import interfacesAndAbstraction._02_MultipleImplementation.interfaces.Person;

public class Citizen implements Person, Identifiable, Birthable {

    private String name;
    private int age;
    private String id;
    private String birthdate;

    public Citizen(String name, int age, String id, String birthdate) {
        this.setName(name);
        this.setAge(age);
        this.setId(id);
        this.setBirthdate(birthdate);
    }

    private void setName(String name) {
        if (name == null || name.trim().isEmpty()) {
            throw new IllegalArgumentException("Name cannot be null or empty.");
        }

        this.name = name;
    }

    private void setAge(int age) {
        if (age < 0) {
            throw new IllegalArgumentException("Age cannot be less than zero.");
        }

        this.age = age;
    }

    private void setId(String id) {
        if (id == null || id.trim().isEmpty()) {
            throw new IllegalArgumentException("Identifiable cannot be null or empty.");
        }

        this.id = id;
    }

    private void setBirthdate(String birthdate) {
        if (birthdate == null || birthdate.trim().isEmpty()) {
            throw new IllegalArgumentException("Birthdate cannot be null or empty.");
        }
        this.birthdate = this.birthdate;
    }

    public String getName() {
        return name;
    }

    public int getAge() {
        return age;
    }

    public String getId() {
        return id;
    }

    public String getBirthdate() {
        return birthdate;
    }
}
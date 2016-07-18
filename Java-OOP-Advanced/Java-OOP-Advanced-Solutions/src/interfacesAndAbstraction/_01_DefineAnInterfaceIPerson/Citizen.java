package interfacesAndAbstraction._01_DefineAnInterfaceIPerson;

public class Citizen implements Person {

    private String name;
    private int age;

    public Citizen(String name, int age) {
        this.setName(name);
        this.setAge(age);
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

    public String getName() {
        return name;
    }

    public int getAge() {
        return age;
    }
}
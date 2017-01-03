package inheritance._06_Animals.models;

import inheritance._06_Animals.interfaces.SoundProducible;

public class Animal implements SoundProducible {
    private String name;
    private int age;
    private String gender;

    public Animal(String name, int age, String gender) {
        this.setName(name);
        this.setAge(age);
        this.setGender(gender);
    }

    private void setName(String name) {
        if (name == null || name.trim().length() == 0) {
            throw new IllegalArgumentException("Invalid input!");
        }

        this.name = name;
    }

    private void setAge(int age) {
        if (age < 0) {
            throw new IllegalArgumentException("Invalid input!");
        }

        this.age = age;
    }

    private void setGender(String gender) {
        if (gender == null || gender.trim().length() == 0) {
            throw new IllegalArgumentException("Invalid input!");
        }

        this.gender = gender;
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append(this.getClass().getSimpleName()).append(System.lineSeparator());
        sb.append(String.format("%s %d %s", this.name, this.age, this.gender));

        return sb.toString();
    }

    @Override
    public void produceSound() {
        System.out.println("Not implemented!");
    }
}
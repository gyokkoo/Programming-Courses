package inheritance._06_Animals.models;

public class Kitten extends Cat {
    public Kitten(String name, int age) {
        super(name, age, "Female");
    }

    @Override
    public void produceSound() {
        System.out.println("Miau");
    }
}

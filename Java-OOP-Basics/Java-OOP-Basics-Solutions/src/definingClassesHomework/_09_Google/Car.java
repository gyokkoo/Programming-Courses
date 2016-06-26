package definingClassesHomework._09_Google;

public class Car {
    private String model;
    private Integer speed;

    public Car(String model, Integer speed) {
        this.model = model;
        this.speed = speed;
    }

    @Override
    public String toString() {
        return String.format("%s %s", this.model, this.speed);
    }
}

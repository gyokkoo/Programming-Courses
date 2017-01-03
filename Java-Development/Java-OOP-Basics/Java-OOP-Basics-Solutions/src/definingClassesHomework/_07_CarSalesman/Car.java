package definingClassesHomework._07_CarSalesman;

public class Car {
    private static final String DEFAULT_VALUE = "n/a";
    private String model;
    private Engine engine;
    private int weight;
    private String color;

    public Car(String model, Engine engine) {
        this(model, engine, 0, DEFAULT_VALUE);
    }

    public Car(String model, Engine engine, int weight) {
        this(model, engine, weight, DEFAULT_VALUE);
    }

    public Car(String model, Engine engine, String color) {
        this(model, engine, 0, color);
    }

    public Car(String model, Engine engine, int weight, String color) {
        this.model = model;
        this.engine = engine;
        this.weight = weight;
        this.color = color;
    }

    @Override
    public String toString() {
        StringBuilder result = new StringBuilder();
        result.append(this.model).append(":").append(System.lineSeparator());
        result.append(this.engine);
        result.append("  Weight: ").append(this.weight == 0 ? DEFAULT_VALUE : this.weight).append(System.lineSeparator());
        result.append("  Color: ").append(this.color);

        return result.toString();
    }
}

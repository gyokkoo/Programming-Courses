package definingClassesHomework._07_CarSalesman;

public class Engine {
    private static final String DEFAULT_VALUE = "n/a";
    private String model;
    private int power;
    private int displacement;
    private String efficiency;

    public Engine(String model, int power) {
        this(model, power, 0, DEFAULT_VALUE);
    }

    public Engine(String model, int power, int displacement) {
        this(model, power, displacement, DEFAULT_VALUE);
    }

    public Engine(String model, int power, String efficiency) {
        this(model, power, 0, efficiency);
    }

    public Engine(String model, int power, int displacement, String efficiency) {
        this.model = model;
        this.power = power;
        this.displacement = displacement;
        this.efficiency = efficiency;
    }

    @Override
    public String toString() {
        StringBuilder result = new StringBuilder();
        result.append(String.format("  %s:%n", this.model));
        result.append(String.format("    Power: %d%n", this.power));
        result.append(String.format("    Displacement: %s%n", this.displacement == 0 ? DEFAULT_VALUE : this.displacement));
        result.append(String.format("    Efficiency: %s%n", this.efficiency));

        return result.toString();
    }
}

package definingClassesHomework._06_RawData;

import java.util.List;

public class Car {
    private String model;
    private Engine engine;
    private Cargo cargo;
    private List<Tire> tires;

    public Car(String model, Engine engine, Cargo cargo, List<Tire> tires) {
        this.model = model;
        this.engine = engine;
        this.cargo = cargo;
        this.tires = tires;
    }

    public List<Tire> getTires() {
        return tires;
    }

    public Engine getEngine() {
        return engine;
    }

    @Override
    public String toString() {
        return this.model;
    }
}

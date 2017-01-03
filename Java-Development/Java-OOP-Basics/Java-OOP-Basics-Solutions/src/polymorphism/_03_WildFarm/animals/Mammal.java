package polymorphism._03_WildFarm.animals;

import java.text.DecimalFormat;

public abstract class Mammal extends Animal {

    private String livingRegion;

    public Mammal(String name, Double weight, String livingRegion) {
        super(name, weight);
        this.livingRegion = livingRegion;
    }

    protected String getLivingRegion() {
        return livingRegion;
    }

    @Override
    public String toString() {
        DecimalFormat df = new DecimalFormat("0.#########");

        return String.format("%s[%s, %s, %s, %s]",
                this.getClass().getSimpleName(),
                this.getAnimalName(),
                df.format(this.getAnimalWeight()),
                this.getLivingRegion(),
                this.getFoodEaten());
    }
}

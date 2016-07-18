package interfacesAndAbstraction._10_MooD3.models;

public class Demon extends GameObjectImpl {

    private static final String CHARACTER_TYPE = "Demon";

    public Demon(String username, int level, Comparable specialPoints) {
        super(username, CHARACTER_TYPE, level, specialPoints);
    }

    @Override
    public String toString() {

        return super.toString() +
                System.lineSeparator() +
                (Double) this.getSpecialPoints() * this.getLevel();
    }
}

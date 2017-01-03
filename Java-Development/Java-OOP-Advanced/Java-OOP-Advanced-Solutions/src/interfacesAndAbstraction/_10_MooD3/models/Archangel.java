package interfacesAndAbstraction._10_MooD3.models;

public class Archangel extends GameObjectImpl {

    private static final String CHARACTER_TYPE = "Archangel";

    public Archangel(String username, int level, Comparable specialPoints) {
        super(username, CHARACTER_TYPE, level, specialPoints);
    }

    @Override
    public String toString() {

        return super.toString() +
                System.lineSeparator() +
                (Integer) this.getSpecialPoints() * this.getLevel();
    }
}

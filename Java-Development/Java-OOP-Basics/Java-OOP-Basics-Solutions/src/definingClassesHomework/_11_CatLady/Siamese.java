package definingClassesHomework._11_CatLady;

public class Siamese extends Cat{
    private double earSize;

    public Siamese(String name, double earSize) {
        super(name);
        this.earSize = earSize;
    }

    @Override
    public String toString() {
        return String.format("Siamese %s %.0f", super.getName(), this.earSize);

    }
}

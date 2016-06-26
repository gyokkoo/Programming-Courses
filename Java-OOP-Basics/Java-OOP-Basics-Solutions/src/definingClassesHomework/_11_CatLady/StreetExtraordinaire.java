package definingClassesHomework._11_CatLady;

public class StreetExtraordinaire extends Cat {
    private double decibelsOfMeows;

    public StreetExtraordinaire(String name, double decibelsOfMeows) {
        super(name);
        this.decibelsOfMeows = decibelsOfMeows;
    }

    @Override
    public String toString() {
        return String.format("StreetExtraordinaire %s %.0f", super.getName(), this.decibelsOfMeows);
    }
}

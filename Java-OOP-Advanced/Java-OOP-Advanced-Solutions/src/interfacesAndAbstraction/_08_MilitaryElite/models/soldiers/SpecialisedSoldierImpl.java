package interfacesAndAbstraction._08_MilitaryElite.models.soldiers;

import interfacesAndAbstraction._08_MilitaryElite.interfaces.SpecialisedSoldier;

public abstract class SpecialisedSoldierImpl extends PrivateImpl implements SpecialisedSoldier {

    private String corps;

    protected SpecialisedSoldierImpl(int id, String firstName, String lastName, double salary, String corps) {
        super(id, firstName, lastName, salary);
        this.setCorps(corps);
    }

    public String getCorps() {
        return corps;
    }

    private void setCorps(String corps) {
        if (!corps.equals("Airforces") && !corps.equals("Marines")) {
            throw new IllegalArgumentException("Invalid corps");
        }

        this.corps = corps;
    }

    @Override
    public String toString() {
        return String.format("%s%nCorps: %s", super.toString(), this.getCorps());
    }
}
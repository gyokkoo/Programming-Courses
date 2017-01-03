package interfacesAndAbstraction._08_MilitaryElite.models.soldiers;

import interfacesAndAbstraction._08_MilitaryElite.interfaces.Soldier;

public abstract class SoldierImpl implements Soldier {

    private int id;
    private String firstName;
    private String lastName;

    protected SoldierImpl(int id, String firstName, String lastName) {
        this.setId(id);
        this.setFirstName(firstName);
        this.setLastName(lastName);
    }

    public int getId() {
        return id;
    }

    private void setId(int id) {
        this.id = id;
    }

    public String getFirstName() {
        return firstName;
    }

    private void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public String getLastName() {
        return lastName;
    }

    private void setLastName(String lastName) {
        this.lastName = lastName;
    }

    @Override
    public String toString() {
        return String.format("Name: %s %s Id: %d",
                this.getFirstName(),
                this.getLastName(),
                this.getId());
    }
}

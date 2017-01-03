package interfacesAndAbstraction._06_BirthdayCelebrations.models;

import interfacesAndAbstraction._06_BirthdayCelebrations.interfaces.Birthable;

public class Pet implements Birthable {

    private String name;
    private String birthdate;

    public Pet(String name, String birthdate) {
        this.name = name;
        this.birthdate = birthdate;
    }

    private String getName() {
        return name;
    }

    private void setName(String name) {
        this.name = name;
    }

    private void setBirthdate(String birthdate) {
        this.birthdate = birthdate;
    }

    @Override
    public String getBirthdate() {
        return birthdate;
    }

    @Override
    public String getBirthYear() {
        return this.birthdate.split("/")[2];
    }
}

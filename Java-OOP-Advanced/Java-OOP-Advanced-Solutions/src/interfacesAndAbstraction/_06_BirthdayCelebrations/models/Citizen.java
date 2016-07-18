package interfacesAndAbstraction._06_BirthdayCelebrations.models;

import interfacesAndAbstraction._06_BirthdayCelebrations.interfaces.Birthable;
import interfacesAndAbstraction._06_BirthdayCelebrations.interfaces.Identifiable;

public class Citizen implements Identifiable, Birthable {

    private String name;
    private Integer age;
    private String id;
    private String birthdate;

    public Citizen(String name, Integer age, String id, String birthdate) {
        this.setName(name);
        this.setAge(age);
        this.setId(id);
        this.setBirthdate(birthdate);
    }

    public String getBirthdate() {
        return birthdate;
    }

    public String getId() {
        return id;
    }

    private void setBirthdate(String birthdate) {
        this.birthdate = birthdate;
    }

    private String getName() {
        return name;
    }

    private void setName(String name) {
        this.name = name;
    }

    private Integer getAge() {
        return age;
    }

    private void setAge(Integer age) {
        this.age = age;
    }


    private void setId(String id) {
        this.id = id;
    }

    public String getBirthYear() {
        return this.birthdate.split("/")[2];
    }

    public Boolean checkId(String lastDigits) {
        return this.getId().endsWith(lastDigits);
    }
}

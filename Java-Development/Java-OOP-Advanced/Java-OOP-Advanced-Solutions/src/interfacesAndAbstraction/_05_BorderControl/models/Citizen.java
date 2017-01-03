package interfacesAndAbstraction._05_BorderControl.models;

import interfacesAndAbstraction._05_BorderControl.Identifiable;

public class Citizen implements Identifiable {

    private String name;
    private Integer age;
    private String id;

    public Citizen(String name, Integer age, String id) {
        this.setName(name);
        this.setAge(age);
        this.setId(id);
    }

    public String getId() {
        return id;
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

    public Boolean checkId(String lastDigits) {
        return this.getId().endsWith(lastDigits);
    }
}

package interfacesAndAbstraction._07_FoodShortage.models;

import interfacesAndAbstraction._07_FoodShortage.interfaces.Birthable;
import interfacesAndAbstraction._07_FoodShortage.interfaces.Buyer;
import interfacesAndAbstraction._07_FoodShortage.interfaces.Identifiable;
import interfacesAndAbstraction._07_FoodShortage.interfaces.Person;

public class Citizen implements Person, Identifiable, Birthable, Buyer {

    private static final Integer BOUGHT_FOOD_AMOUNT = 10;

    private String name;
    private Integer age;
    private String id;
    private String birthdate;
    private Integer food;

    public Citizen(String name, Integer age, String id, String birthdate) {
        this.setName(name);
        this.setAge(age);
        this.setId(id);
        this.setBirthdate(birthdate);
        this.setFood(0);
    }

    private void setFood(Integer food) {
        this.food = food;
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

    public String getName() {
        return name;
    }

    private void setName(String name) {
        this.name = name;
    }

    public int getAge() {
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

    public int getFood() {
        return food;
    }

    public void buyFood() {
        this.setFood(this.getFood() + BOUGHT_FOOD_AMOUNT);
    }
}

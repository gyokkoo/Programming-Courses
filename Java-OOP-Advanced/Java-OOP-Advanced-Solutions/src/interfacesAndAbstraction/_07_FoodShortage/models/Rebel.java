package interfacesAndAbstraction._07_FoodShortage.models;

import interfacesAndAbstraction._07_FoodShortage.interfaces.Buyer;
import interfacesAndAbstraction._07_FoodShortage.interfaces.Person;

public class Rebel implements Buyer, Person {

    private static final Integer BOUGHT_FOOD_AMOUNT = 5;

    private String name;
    private int age;
    private String group;
    private int food;

    public Rebel(String name, int age, String group) {
        this.setName(name);
        this.setAge(age);
        this.setGroup(group);
        this.setFood(0);
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

    private String getGroup() {
        return group;
    }

    private void setGroup(String group) {
        this.group = group;
    }

    public int getFood() {
        return food;
    }

    private void setFood(Integer food) {
        this.food = food;
    }

    public void buyFood() {
        this.setFood(this.getFood() + BOUGHT_FOOD_AMOUNT);
    }
}

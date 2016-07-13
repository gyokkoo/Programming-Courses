package polymorphism._03_WildFarm.animals;

import polymorphism._03_WildFarm.foods.Food;

public abstract class Animal {

    private String animalName;
    private Double animalWeight;
    private Integer foodEaten;

    public Animal(String name, Double weight) {
        this.animalName = name;
        this.animalWeight = weight;
        this.foodEaten = 0;
    }

    protected void setFoodEaten(Integer foodEaten) {
        this.foodEaten = foodEaten;
    }

    protected Integer getFoodEaten() {
        return foodEaten;
    }

    protected String getAnimalName() {
        return animalName;
    }

    protected Double getAnimalWeight() {
        return animalWeight;
    }

    public abstract void makeSound();

    public void eat(Food food) {
        this.foodEaten += food.getQuantity();
    }
}
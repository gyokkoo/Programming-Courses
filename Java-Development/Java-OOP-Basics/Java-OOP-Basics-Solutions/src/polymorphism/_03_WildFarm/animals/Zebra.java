package polymorphism._03_WildFarm.animals;

import polymorphism._03_WildFarm.foods.Food;

public class Zebra extends Mammal {

    public Zebra(String name, Double weight, String livingRegion) {
        super(name, weight, livingRegion);
    }

    @Override
    public void makeSound() {
        System.out.println("Zs");
    }

    @Override
    public void eat(Food food) {
        if (((Food) food).getClass().getSimpleName().equals("Meat")) {
            throw new IllegalArgumentException("Zebras are not eating that type of food!");
        }

        super.eat(food);
    }
}

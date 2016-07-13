package polymorphism._03_WildFarm.animals;

import polymorphism._03_WildFarm.foods.Food;

public class Tiger extends Felime {

    public Tiger(String name, Double weight, String livingRegion) {
        super(name, weight, livingRegion);
    }

    @Override
    public void makeSound() {
        System.out.println("ROAAR!!!");
    }

    @Override
    public void eat(Food food) {
        if (((Food) food).getClass().getSimpleName().equals("Vegetable")) {
            throw new IllegalArgumentException("Tigers are not eating that type of food!");
        }

        super.eat(food);
    }
}
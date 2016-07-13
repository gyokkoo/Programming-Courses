package polymorphism._03_WildFarm.animals;

import polymorphism._03_WildFarm.foods.Food;

public class Mouse extends Mammal {

    public Mouse(String name, Double weight, String livingRegion) {
        super(name, weight, livingRegion);
    }

    @Override
    public void makeSound() {
        System.out.println("SQUEEEAAAK!");
    }

    @Override
    public void eat(Food food) {
        if (((Food) food).getClass().getSimpleName().equals("Meat")) {
            throw new IllegalArgumentException("Mouses are not eating that type of food!");
        }

        super.eat(food);
    }
}
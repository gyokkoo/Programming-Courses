package encapsulation._05_PizzaCalories.models;

import java.util.ArrayList;
import java.util.List;

public class Pizza {
    private String name;
    private Dough dough;
    private int toppingsCount;
    private List<Topping> toppings;

    public Pizza(String name, int toppingsCount) {
        this.setName(name);
        this.setToppingsCount(toppingsCount);
        this.toppings = new ArrayList<>();
    }

    public void setDough(Dough dough) {
        this.dough = dough;
    }

    public void addTopping(Topping topping) {
        this.toppings.add(topping);
    }

    private double getTotalCalories() {
        double total = this.dough.getCalories();
        for (Topping topping : toppings) {
            total += topping.getCalories();
        }

        return total;
    }

    private void setName(String name) {
        if (name == null || name.length() < 1 || 15 < name.length()) {
            throw new IllegalArgumentException("Pizza name should be between 1 and 15 symbols.");
        }

        this.name = name;
    }

    private void setToppingsCount(int toppingsCount) {
        if (toppingsCount < 0 || 10 < toppingsCount) {
            throw new IllegalArgumentException("Number of toppings should be in range [0..10].");
        }

        this.toppingsCount = toppingsCount;
    }

    @Override
    public String toString() {
        return String.format("%s - %.2f Calories.", this.name, this.getTotalCalories());
    }
}
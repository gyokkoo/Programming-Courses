package softuni.people;

import softuni.items.Toy;

import java.util.List;

public class Child {
    private List<Toy> toys;
    private double foodCost;
    private double toyCost;

    public Child(double foodCost, List<Toy> toys) {
        this.toys = toys;
        this.foodCost = foodCost;
        this.calculateToysCost();
    }

    public double getCost() {
        return this.foodCost + this.toyCost;
    }

    private void calculateToysCost() {
        this.toyCost = toys.stream()
                .mapToDouble(Toy::getCost)
                .sum();
    }
}

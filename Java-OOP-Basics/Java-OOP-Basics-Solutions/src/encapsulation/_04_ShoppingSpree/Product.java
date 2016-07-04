package encapsulation._04_ShoppingSpree;

public class Product {
    private String name;
    private Double cost;

    public Product(String name, Double cost) {
        this.setName(name);
        this.setCost(cost);
    }

    private void setName(String name) {
        if (name == null || name.isEmpty() || name.equals(" ")) {
            throw new IllegalArgumentException("Name cannot be empty");
        }

        this.name = name;
    }

    private void setCost(Double cost) {
        if (cost < 0) {
            throw new IllegalArgumentException("Money cannot be negative");
        }

        this.cost = cost;
    }

    public String getName() {
        return name;
    }

    public Double getCost() {
        return cost;
    }
}

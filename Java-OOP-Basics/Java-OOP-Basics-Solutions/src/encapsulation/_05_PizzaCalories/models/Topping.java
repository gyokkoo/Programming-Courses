package encapsulation._05_PizzaCalories.models;

public class Topping {
    private String type;
    private int weight;

    public Topping(String type, int weight) {
        this.setType(type);
        this.setWeight(weight);
    }

    public double getCalories() {
        return 2 * this.weight * this.getModifier();
    }

    private void setType(String type) {
        if (!type.equalsIgnoreCase("meat") &&
                !type.equalsIgnoreCase("veggies") &&
                !type.equalsIgnoreCase("cheese") &&
                !type.equalsIgnoreCase("sauce")) {
            throw new IllegalArgumentException(
                    String.format("Cannot place %s on top of your pizza.", type));
        }
        this.type = type;
    }

    private void setWeight(int weight) {
        if (weight < 1 || 50 < weight) {
            throw new IllegalArgumentException(
                    String.format("%s weight should be in the range [1..50].", this.type));
        }

        this.weight = weight;
    }

    private double getModifier() {
        switch (this.type.toLowerCase()) {
            case "meat":
                return 1.2;
            case "veggies":
                return 0.8;
            case "cheese":
                return 1.1;
            case "sauce":
                return 0.9;
            default:
                throw new IllegalArgumentException("Unknown type");
        }
    }
}

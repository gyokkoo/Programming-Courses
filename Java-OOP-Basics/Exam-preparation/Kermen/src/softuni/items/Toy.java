package softuni.items;

public class Toy {
    double cost;

    public Toy(double cost) {
        this.setCost(cost);
    }

    public double getCost() {
        return cost;
    }

    private void setCost(double cost) {
        this.cost = cost;
    }
}

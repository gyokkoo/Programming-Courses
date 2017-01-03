package polymorphism._03_WildFarm.foods;

public abstract class Food {

    private Integer quantity;

    public Food(Integer quantity) {
        this.setQuantity(quantity);
    }

    private void setQuantity(Integer quantity) {
        if (quantity < 0) {
            throw new IllegalArgumentException("The food quantity must be positive");
        }

        this.quantity = quantity;
    }

    public Integer getQuantity() {
        return quantity;
    }
}

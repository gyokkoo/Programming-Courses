package encapsulation._04_ShoppingSpree;

import java.util.ArrayList;
import java.util.List;

public class Person {
    private String name;
    private Double money;
    private List<Product> bagOfProducts;

    public Person(String name, Double money) {
        this.setName(name);
        this.setMoney(money);
        this.bagOfProducts = new ArrayList<>();
    }

    private void setName(String name) {
        if (name == null || name.isEmpty() || name.equals(" ")) {
            throw new IllegalArgumentException("Name cannot be empty");
        }

        this.name = name;
    }

    private void setMoney(Double money) {
        if (money < 0) {
            throw new IllegalArgumentException("Money cannot be negative");
        }

        this.money = money;
    }

    public String buy(Product product) {
        String result = "";
        Double productCost = product.getCost();
        if (this.money >= productCost) {
            this.money -= productCost;
            this.bagOfProducts.add(product);
            result = String.format("%s bought %s", this.name, product.getName());
        } else {
            result = String.format("%s can't afford %s", this.name, product.getName());
        }

        return result;
    }

    @Override
    public String toString() {
        StringBuilder helpBuilder = new StringBuilder();
        helpBuilder.append(this.name);
        helpBuilder.append(" - ");
        if (this.bagOfProducts.size() >= 1) {
            for (int i = 0; i < this.bagOfProducts.size() - 1; i++) {
                helpBuilder.append(this.bagOfProducts.get(i).getName()).append(", ");
            }
            helpBuilder.append(this.bagOfProducts.get(this.bagOfProducts.size() - 1).getName());
        } else {
            helpBuilder.append("Nothing bought");
        }

        return helpBuilder.toString();
    }
}
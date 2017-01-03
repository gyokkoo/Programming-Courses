package encapsulation._05_PizzaCalories;

import encapsulation._05_PizzaCalories.models.Dough;
import encapsulation._05_PizzaCalories.models.Pizza;
import encapsulation._05_PizzaCalories.models.Topping;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    private static BufferedReader reader;

    public static void main(String[] args) throws IOException {
        reader = new BufferedReader(new InputStreamReader(System.in));

        try {
            while (true) {
                String[] lineArgs = reader.readLine().split(" ");
                if (lineArgs[0].equals("END")) {
                    break;
                }

                String result = null;
                switch (lineArgs[0]) {
                    case "Pizza":
                        Pizza pizza = tryMakePizza(lineArgs);
                        result = pizza.toString();
                        break;
                    case "Dough":
                        Dough dough = tryMakeDough(lineArgs);
                        result = String.format("%.2f", dough.getCalories());
                        break;
                    case "Topping":
                        Topping topping = tryMakeTopping(lineArgs);
                        result = String.format("%.2f", topping.getCalories());
                        break;
                }
                System.out.println(result);
            }
        } catch (IllegalArgumentException iae) {
            System.out.println(iae.getMessage());
        }
    }

    private static Pizza tryMakePizza(String[] input) throws IOException {
        String name = input[1];
        int toppingCount = Integer.parseInt(input[2]);
        Pizza pizza = new Pizza(name, toppingCount);
        String[] line = reader.readLine().split(" ");
        Dough dough = tryMakeDough(line);
        pizza.setDough(dough);
        for (int i = 0; i < toppingCount; i++) {
            String[] toppingArgs = reader.readLine().split(" ");
            Topping topping = tryMakeTopping(toppingArgs);
            pizza.addTopping(topping);
        }

        return pizza;
    }

    private static Topping tryMakeTopping(String[] input) {
        String type = input[1];
        int weight = Integer.parseInt(input[2]);
        Topping topping = new Topping(type, weight);

        return topping;
    }

    private static Dough tryMakeDough(String[] input) {
        String flour = input[1];
        String technique = input[2];
        int weight = Integer.parseInt(input[3]);
        Dough dough = new Dough(flour, technique, weight);

        return dough;
    }
}

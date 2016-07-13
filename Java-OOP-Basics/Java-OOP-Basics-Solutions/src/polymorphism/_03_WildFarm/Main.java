package polymorphism._03_WildFarm;

import polymorphism._03_WildFarm.animals.*;
import polymorphism._03_WildFarm.foods.Food;
import polymorphism._03_WildFarm.foods.Meat;
import polymorphism._03_WildFarm.foods.Vegetable;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        while (true) {
            String[] animalTokens = reader.readLine().split("\\s+");
            if (animalTokens[0].equals("End")) {
                break;
            }

            Animal animal = createAnimal(animalTokens);
            animal.makeSound();

            String[] foodTokens = reader.readLine().split("\\s+");
            Food food = createFood(foodTokens);
            try {
                animal.eat(food);
            } catch (IllegalArgumentException e) {
                System.out.println(e.getMessage());
            }

            System.out.println(animal);
        }
    }

    private static Food createFood(String[] foodTokens) {
        String foodType = foodTokens[0];
        Integer foodQuantity = Integer.valueOf(foodTokens[1]);

        switch (foodType.toLowerCase()) {
            case "meat":
                return new Meat(foodQuantity);
            case "vegetable":
                return new Vegetable(foodQuantity);
        }

        return null;
    }

    private static Animal createAnimal(String[] animalTokens) {
        String animalType = animalTokens[0];
        String animalName = animalTokens[1];
        Double animalWeight = Double.valueOf(animalTokens[2]);
        String animalLivingRegion = animalTokens[3];

        switch (animalType.toLowerCase()) {
            case "mouse":
                return new Mouse(animalName, animalWeight, animalLivingRegion);
            case "cat":
                String catBreed = animalTokens[4];
                return new Cat(animalName, animalWeight, animalLivingRegion, catBreed);
            case "tiger":
                return new Tiger(animalName, animalWeight, animalLivingRegion);
            case "zebra":
                return new Zebra(animalName, animalWeight, animalLivingRegion);
        }

        return null;
    }
}
package inheritance._06_Animals;

import inheritance._06_Animals.models.*;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        try {
            while (true) {
                String command = reader.readLine();
                if (command.equals("Beast!")) {
                    break;
                }

                String[] tokens = reader.readLine().split(" ");
                String name = tokens[0];
                int age = Integer.parseInt(tokens[1]);
                String gender = null;
                Animal animal = null;
                switch (command) {
                    case "Dog":
                        gender = tokens[2];
                        animal = new Dog(name, age, gender);
                        break;
                    case "Cat":
                        gender = tokens[2];
                        animal = new Cat(name, age, gender);
                        break;
                    case "Frog":
                        gender = tokens[2];
                        animal = new Frog(name, age, gender);
                        break;
                    case "Kitten":
                        animal = new Kitten(name, age);
                        break;
                    case "Tomcat":
                        animal = new Tomcat(name, age);
                        break;
                    default:
                        gender = tokens[2];
                        animal = new Animal(name, age, gender);
                }
                System.out.println(animal);
                animal.produceSound();
            }
        } catch (IllegalArgumentException e) {
            System.out.println(e.getMessage());
        }
    }
}
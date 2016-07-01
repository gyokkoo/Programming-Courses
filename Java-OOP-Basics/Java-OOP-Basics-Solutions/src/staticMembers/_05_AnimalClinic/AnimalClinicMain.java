package staticMembers._05_AnimalClinic;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;

public class AnimalClinicMain {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        while (true) {
            String[] tokens = reader.readLine().split(" ");
            if (tokens[0].equals("End")) {
                break;
            }

            String animalName = tokens[0];
            String animalBreed = tokens[1];
            String command = tokens[2];
            Animal animal = new Animal(animalName, animalBreed);
            switch (command) {
                case "heal":
                    System.out.println(AnimalClinic.healAnimal(animal));
                    break;
                case "rehabilitate":
                    System.out.println(AnimalClinic.rehabilitateAnimal(animal));
                    break;
            }
        }

        System.out.printf("Total healed animals: %d%n", AnimalClinic.getHealedAnimalsCount());
        System.out.printf("Total rehabilitated animals: %d%n", AnimalClinic.getRehabilitatedAnimalsCount());
        String command = reader.readLine();
        if (command.equals("heal")) {
            ArrayList<Animal> healedAnimals = AnimalClinic.getHealedAnimals();
            healedAnimals.forEach(animal -> System.out.println(animal.getName() + " " + animal.getBreed()));
        } else if (command.equals("rehabilitate")) {
            ArrayList<Animal> rehabilitatedAnimals = AnimalClinic.getRehabilitatedAnimals();
            rehabilitatedAnimals.forEach(animal -> System.out.println(animal.getName() + " " + animal.getBreed()));
        }
    }
}

package staticMembers._05_AnimalClinic;

import java.util.ArrayList;

public class AnimalClinic {
    private static int patientId;
    private static int healedAnimalsCount;
    private static int rehabilitatedAnimalsCount;
    private static ArrayList<Animal> healedAnimals;
    private static ArrayList<Animal> rehabilitatedAnimals;

    static {
        patientId = 0;
        healedAnimalsCount = 0;
        rehabilitatedAnimalsCount = 0;
        healedAnimals = new ArrayList<>();
        rehabilitatedAnimals = new ArrayList<>();
    }

    public static int getHealedAnimalsCount() {
        return healedAnimalsCount;
    }

    public static int getRehabilitatedAnimalsCount() {
        return rehabilitatedAnimalsCount;
    }

    public static ArrayList<Animal> getHealedAnimals() {
        return healedAnimals;
    }

    public static ArrayList<Animal> getRehabilitatedAnimals() {
        return rehabilitatedAnimals;
    }

    public static String healAnimal(Animal animal) {
        healedAnimalsCount++;
        patientId++;
        healedAnimals.add(animal);
        return String.format("Patient %d: %s has been healed!", patientId, animal);
    }

    public static String rehabilitateAnimal(Animal animal) {
        rehabilitatedAnimalsCount++;
        patientId++;
        rehabilitatedAnimals.add(animal);
        return String.format("Patient %d: %s has been rehabilitated!", patientId, animal);
    }
}

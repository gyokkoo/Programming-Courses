package enumerationAndAnnotations._13_CustomClassAnnotation;

import enumerationAndAnnotations._13_CustomClassAnnotation.annotations.CustomAnnotation;
import enumerationAndAnnotations._13_CustomClassAnnotation.data.WeaponsRepository;
import enumerationAndAnnotations._13_CustomClassAnnotation.enums.Gem;
import enumerationAndAnnotations._13_CustomClassAnnotation.enums.WeaponType;
import enumerationAndAnnotations._13_CustomClassAnnotation.interfaces.Repository;
import enumerationAndAnnotations._13_CustomClassAnnotation.interfaces.Weapon;
import enumerationAndAnnotations._13_CustomClassAnnotation.models.WeaponImpl;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        Repository weaponsRepository = new WeaponsRepository();
        while (true) {
            String line = reader.readLine();
            if (line.equals("END")) {
                break;
            }

            String[] commandTokens = line.split(";");
            executeCommand(weaponsRepository, commandTokens);
        }
    }

    private static void executeCommand(Repository weaponsRepository, String[] commandTokens) {
        CustomAnnotation annotation = WeaponImpl.class.getAnnotation(CustomAnnotation.class);
        switch (commandTokens[0]) {
            case "Create":
                WeaponType weaponType = WeaponType.valueOf(commandTokens[1]);
                String weaponName = commandTokens[2];
                Weapon weapon = new WeaponImpl(weaponName, weaponType);
                weaponsRepository.addWeapon(weapon);
                break;
            case "Add":
                String weaponToAddName = commandTokens[1];
                int socketIndex = Integer.parseInt(commandTokens[2]);
                Gem gemType = Gem.valueOf(commandTokens[3]);
                weaponsRepository.addGem(weaponToAddName, socketIndex, gemType);
                break;
            case "Remove":
                String weaponToRemoveName = commandTokens[1];
                int index = Integer.parseInt(commandTokens[2]);
                weaponsRepository.removeGem(weaponToRemoveName, index);
                break;
            case "Compare":
                String firstWeaponName = commandTokens[1];
                String secondWeaponName = commandTokens[2];
                weaponsRepository.compareWeapons(firstWeaponName, secondWeaponName);
                break;
            case "Print":
                String weaponToPrint = commandTokens[1];
                weaponsRepository.printWeapon(weaponToPrint);
                break;
            case "Author":
                System.out.printf("Author: %s%n", annotation.author());
                break;
            case "Revision":
                System.out.printf("Revision: %s%n", annotation.revision());
                break;
            case "Description":
                System.out.printf("Class description: %s%n", annotation.description());
                break;
            case "Reviewers":
                System.out.print("Reviewers: ");
                for (int i = 0; i < annotation.reviewers().length - 1; i++) {
                    System.out.print(annotation.reviewers()[i] + ", ");
                }
                System.out.println(annotation.reviewers()[annotation.reviewers().length - 1]);
                break;
        }
    }
}
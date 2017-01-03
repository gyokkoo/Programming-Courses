package enumerationAndAnnotations._14_Refactoring.core;

import enumerationAndAnnotations._14_Refactoring.annotations.ClassInfo;
import enumerationAndAnnotations._14_Refactoring.enums.Gem;
import enumerationAndAnnotations._14_Refactoring.interfaces.*;
import enumerationAndAnnotations._14_Refactoring.interfaces.Runnable;
import enumerationAndAnnotations._14_Refactoring.models.WeaponImpl;

import java.io.IOException;
import java.util.Arrays;

public class Engine implements Runnable {

    private Repository weaponsRepository;
    private WeaponFactory weaponFactory;
    private Reader inputReader;
    private Writer writer;
    private boolean isRunning;

    public Engine(Repository weaponsRepository, WeaponFactory weaponFactory, Reader inputReader, Writer writer) {
        this.weaponsRepository = weaponsRepository;
        this.weaponFactory = weaponFactory;
        this.inputReader = inputReader;
        this.writer = writer;
    }

    @Override
    public void run() throws IOException {
        this.isRunning = true;

        while (isRunning) {
            String line = this.inputReader.read();
            String[] commandTokens = line.split(";");
            switch (commandTokens[0]) {
                case "Create":
                    Weapon weapon = this.weaponFactory.createWeapon(commandTokens);
                    this.weaponsRepository.addWeapon(weapon);
                    break;
                case "Add":
                    Weapon weaponToPutSocket = this.weaponsRepository.getWeapon(commandTokens[1]);
                    int socketIndex = Integer.parseInt(commandTokens[2]);
                    Gem gemType = Gem.valueOf(commandTokens[3]);
                    weaponToPutSocket.putSocket(socketIndex, gemType);
                    break;
                case "Remove":
                    Weapon weaponToRemove = this.weaponsRepository.getWeapon(commandTokens[1]);
                    int index = Integer.parseInt(commandTokens[2]);
                    weaponToRemove.removeSocket(index);
                    break;
                case "Compare":
                    Weapon firstWeapon = this.weaponsRepository.getWeapon(commandTokens[1]);
                    Weapon secondWeapon = this.weaponsRepository.getWeapon(commandTokens[2]);
                    if (firstWeapon.compareTo(secondWeapon) >= 0) {
                        writer.writeLine(String.format("%s (Item Level: %.1f)", firstWeapon.toString(), firstWeapon
                                .getItemLevel()));
                    } else {
                        writer.writeLine(String.format("%s (Item Level: %.1f)", secondWeapon.toString(), secondWeapon
                                .getItemLevel()));
                    }
                    break;
                case "Print":
                    Weapon weaponToPrint = this.weaponsRepository.getWeapon(commandTokens[1]);
                    writer.writeLine(weaponToPrint.toString());
                    break;
                case "Author":
                case "Revision":
                case "Description":
                case "Reviewers":
                    this.printAnnotation(commandTokens);
                    break;
                case "END":
                    this.isRunning = false;
                    break;
            }
        }
    }

    private void printAnnotation(String[] commandTokens) {
        ClassInfo weaponClassInfo = WeaponImpl.class.getAnnotation(ClassInfo.class);
        switch (commandTokens[0]) {
            case "Author":
                writer.writeLine("Author: " + weaponClassInfo.author());
                break;
            case "Revision":
                writer.writeLine("Revision: " + weaponClassInfo.revision());
                break;
            case "Description":
                writer.writeLine("Class description: " + weaponClassInfo.description());
                break;
            case "Reviewers":
                String reviewers = String.join(", ", Arrays.asList(weaponClassInfo.reviewers()));
                writer.writeLine("Reviewers: " + reviewers);
                break;
        }
    }
}
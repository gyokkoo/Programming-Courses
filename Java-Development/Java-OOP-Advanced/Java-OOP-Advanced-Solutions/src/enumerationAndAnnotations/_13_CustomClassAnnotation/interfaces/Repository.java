package enumerationAndAnnotations._13_CustomClassAnnotation.interfaces;

import enumerationAndAnnotations._13_CustomClassAnnotation.enums.Gem;

public interface Repository {

    void addWeapon(Weapon weapon);

    void addGem(String weaponName, int socketIndex, Gem gemType);

    void removeGem(String weaponToRemoveName, int index);

    void printWeapon(String weaponToPrint);

    void compareWeapons(String first, String second);
}

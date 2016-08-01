package enumerationAndAnnotations._10_InfernoInfinity.interfaces;

import enumerationAndAnnotations._10_InfernoInfinity.enums.Gem;

public interface Repository {

    void addWeapon(Weapon weapon);

    void addGem(String weaponName, int socketIndex, Gem gemType);

    void removeGem(String weaponToRemoveName, int index);

    void printWeapon(String weaponToPrint);
}

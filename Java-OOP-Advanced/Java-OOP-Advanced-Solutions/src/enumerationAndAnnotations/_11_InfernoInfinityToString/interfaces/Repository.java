package enumerationAndAnnotations._11_InfernoInfinityToString.interfaces;

import enumerationAndAnnotations._11_InfernoInfinityToString.enums.Gem;

public interface Repository {

    void addWeapon(Weapon weapon);

    void addGem(String weaponName, int socketIndex, Gem gemType);

    void removeGem(String weaponToRemoveName, int index);

    void printWeapon(String weaponToPrint);
}

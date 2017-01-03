package enumerationAndAnnotations._11_InfernoInfinityToString.data;

import enumerationAndAnnotations._11_InfernoInfinityToString.enums.Gem;
import enumerationAndAnnotations._11_InfernoInfinityToString.interfaces.Repository;
import enumerationAndAnnotations._11_InfernoInfinityToString.interfaces.Weapon;

import java.util.HashMap;
import java.util.Map;

public class WeaponsRepository implements Repository {

    private Map<String, Weapon> weapons;

    public WeaponsRepository() {
        this.weapons = new HashMap<>();
    }

    public void addWeapon(Weapon weapon) {
        this.weapons.put(weapon.getName(), weapon);
    }

    public void addGem(String weaponName, int socketIndex, Gem gemType) {
        this.weapons.get(weaponName).putSocket(socketIndex, gemType);
    }

    public void removeGem(String weaponToRemoveName, int index) {
        this.weapons.get(weaponToRemoveName).removeSocket(index);
    }

    public void printWeapon(String weaponToPrint) {
        Weapon weapon = this.weapons.get(weaponToPrint);
        System.out.println(weapon);
    }
}

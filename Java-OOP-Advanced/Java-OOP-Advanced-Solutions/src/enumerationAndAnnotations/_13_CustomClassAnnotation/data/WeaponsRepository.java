package enumerationAndAnnotations._13_CustomClassAnnotation.data;

import enumerationAndAnnotations._13_CustomClassAnnotation.enums.Gem;
import enumerationAndAnnotations._13_CustomClassAnnotation.interfaces.Repository;
import enumerationAndAnnotations._13_CustomClassAnnotation.interfaces.Weapon;

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

    @Override
    public void compareWeapons(String first, String second) {
        Weapon firstWeapon = this.weapons.get(first);
        Weapon secondWeapon = this.weapons.get(second);

        if (firstWeapon.compareTo(secondWeapon) >= 0) {
            System.out.printf("%s (Item Level: %.1f)%n", firstWeapon.toString(), firstWeapon.getItemLevel());
        } else {
            System.out.printf("%s (Item Level: %.1f)%n", secondWeapon.toString(), secondWeapon.getItemLevel());
        }
    }
}

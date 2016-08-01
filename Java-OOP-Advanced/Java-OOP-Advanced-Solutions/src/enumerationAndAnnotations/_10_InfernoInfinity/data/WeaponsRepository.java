package enumerationAndAnnotations._10_InfernoInfinity.data;

import enumerationAndAnnotations._10_InfernoInfinity.enums.Gem;
import enumerationAndAnnotations._10_InfernoInfinity.interfaces.Repository;
import enumerationAndAnnotations._10_InfernoInfinity.interfaces.Weapon;

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

        System.out.printf("%s: %d-%d Damage, +%d Strength, +%d Agility, +%d Vitality%n",
                weapon.getName(), weapon.getMinDamage(), weapon.getMaxDamage(),
                weapon.getStrengthBonus(), weapon.getAgilityBonus(), weapon.getVitalityBonus());
    }
}

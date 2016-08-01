package enumerationAndAnnotations._14_Refactoring.core;

import enumerationAndAnnotations._14_Refactoring.interfaces.Repository;
import enumerationAndAnnotations._14_Refactoring.interfaces.Weapon;

import java.util.HashMap;
import java.util.Map;

public class WeaponsRepository implements Repository {

    private Map<String, Weapon> weapons;

    public WeaponsRepository() {
        this.weapons = new HashMap<>();
    }

    @Override
    public void addWeapon(Weapon weapon) {
        this.weapons.put(weapon.getName(), weapon);
    }

    @Override
    public Weapon getWeapon(String name) {
        return weapons.get(name);
    }
}

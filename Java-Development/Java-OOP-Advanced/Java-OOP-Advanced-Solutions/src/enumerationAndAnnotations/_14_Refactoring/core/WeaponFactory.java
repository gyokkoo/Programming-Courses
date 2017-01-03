package enumerationAndAnnotations._14_Refactoring.core;

import enumerationAndAnnotations._14_Refactoring.enums.WeaponType;
import enumerationAndAnnotations._14_Refactoring.interfaces.Weapon;
import enumerationAndAnnotations._14_Refactoring.models.WeaponImpl;

public class WeaponFactory {

    public Weapon createWeapon(String[] commandTokens) {
        WeaponType weaponType = WeaponType.valueOf(commandTokens[1]);
        String weaponName = commandTokens[2];

        return new WeaponImpl(weaponName, weaponType);
    }
}

package enumerationAndAnnotations._14_Refactoring.interfaces;

import enumerationAndAnnotations._14_Refactoring.enums.Gem;
import enumerationAndAnnotations._14_Refactoring.enums.WeaponType;

public interface Weapon extends Comparable<Weapon> {

    String getName();

    WeaponType getType();

    int getMinDamage();

    int getMaxDamage();

    int getStrengthBonus();

    int getAgilityBonus();

    int getVitalityBonus();

    double getItemLevel();

    void putSocket(int socketIndex, Gem gemType);

    void removeSocket(int index);
}

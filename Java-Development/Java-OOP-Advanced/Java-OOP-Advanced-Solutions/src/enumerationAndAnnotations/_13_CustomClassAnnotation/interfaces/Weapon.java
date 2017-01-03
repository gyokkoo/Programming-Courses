package enumerationAndAnnotations._13_CustomClassAnnotation.interfaces;

import enumerationAndAnnotations._13_CustomClassAnnotation.enums.Gem;
import enumerationAndAnnotations._13_CustomClassAnnotation.enums.WeaponType;

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

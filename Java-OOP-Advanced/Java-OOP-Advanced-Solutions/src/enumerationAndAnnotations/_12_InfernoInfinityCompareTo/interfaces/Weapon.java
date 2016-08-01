package enumerationAndAnnotations._12_InfernoInfinityCompareTo.interfaces;

import enumerationAndAnnotations._12_InfernoInfinityCompareTo.enums.Gem;
import enumerationAndAnnotations._12_InfernoInfinityCompareTo.enums.WeaponType;

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

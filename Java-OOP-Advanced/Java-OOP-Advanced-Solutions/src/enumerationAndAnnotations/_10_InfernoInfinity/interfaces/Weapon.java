package enumerationAndAnnotations._10_InfernoInfinity.interfaces;

import enumerationAndAnnotations._10_InfernoInfinity.enums.Gem;
import enumerationAndAnnotations._10_InfernoInfinity.enums.WeaponType;

public interface Weapon {

    String getName();

    WeaponType getType();

    int getMinDamage();

    int getMaxDamage();

    int getStrengthBonus();

    int getAgilityBonus();

    int getVitalityBonus();

    void putSocket(int socketIndex, Gem gemType);

    void removeSocket(int index);
}

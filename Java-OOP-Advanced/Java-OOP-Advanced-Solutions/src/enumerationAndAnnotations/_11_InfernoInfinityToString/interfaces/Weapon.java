package enumerationAndAnnotations._11_InfernoInfinityToString.interfaces;

import enumerationAndAnnotations._11_InfernoInfinityToString.enums.Gem;
import enumerationAndAnnotations._11_InfernoInfinityToString.enums.WeaponType;

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

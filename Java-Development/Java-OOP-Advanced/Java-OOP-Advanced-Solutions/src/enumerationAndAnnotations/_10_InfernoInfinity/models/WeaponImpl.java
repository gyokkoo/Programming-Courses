package enumerationAndAnnotations._10_InfernoInfinity.models;

import enumerationAndAnnotations._10_InfernoInfinity.enums.Gem;
import enumerationAndAnnotations._10_InfernoInfinity.enums.WeaponType;
import enumerationAndAnnotations._10_InfernoInfinity.interfaces.Weapon;

public class WeaponImpl implements Weapon {

    private String name;
    private WeaponType type;

    private int minDamage;
    private int maxDamage;
    private Gem[] sockets;

    public WeaponImpl(String name, WeaponType type) {
        this.setName(name);
        this.setType(type);
        this.setMinDamage(type.getMinDamage());
        this.setMaxDamage(type.getMaxDamage());
        this.setSockets(type.getSocketsCount());
    }

    @Override
    public String getName() {
        return this.name;
    }

    @Override
    public WeaponType getType() {
        return this.type;
    }

    @Override
    public int getMinDamage() {
        return this.minDamage + this.getStrengthBonus() * 2 + this.getAgilityBonus();
    }

    @Override
    public int getMaxDamage() {
        return this.maxDamage + this.getStrengthBonus() * 3 + this.getAgilityBonus() * 4;
    }

    private void setName(String name) {
        this.name = name;
    }

    private void setType(WeaponType type) {
        this.type = type;
    }

    private void setMaxDamage(int maxDamage) {
        this.maxDamage = maxDamage;
    }

    private void setMinDamage(int minDamage) {
        this.minDamage = minDamage;
    }

    private void setSockets(int socketsCount) {
        this.sockets = new Gem[socketsCount];
    }

    @Override
    public int getStrengthBonus() {
        int strengthBonus = 0;
        for (Gem socket : sockets) {
            if (socket != null) {
                strengthBonus += socket.getStrength();
            }
        }

        return strengthBonus;
    }

    @Override
    public int getAgilityBonus() {
        int agilityBonus = 0;
        for (Gem socket : sockets) {
            if (socket != null) {
                agilityBonus += socket.getAgility();
            }
        }

        return agilityBonus;
    }

    @Override
    public int getVitalityBonus() {
        int vitalityBonus = 0;
        for (Gem socket : sockets) {
            if (socket != null) {
                vitalityBonus += socket.getVitality();
            }
        }

        return vitalityBonus;
    }

    @Override
    public void putSocket(int socketIndex, Gem gem) {
        if (0 <= socketIndex && socketIndex < this.sockets.length) {
            this.sockets[socketIndex] = gem;
        }
    }

    @Override
    public void removeSocket(int index) {
        if (0 <= index && index < this.sockets.length) {
            this.sockets[index] = null;
        }
    }
}

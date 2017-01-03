package enumerationAndAnnotations._11_InfernoInfinityToString.enums;

public enum WeaponType {
    AXE(5, 10, 4),
    SWORD(4, 6, 3),
    KNIFE(3, 4, 2);

    private int minDamage;
    private int maxDamage;
    private int socketsCount;

    private WeaponType(int minDamage, int maxDamage, int socketsCount) {
        this.setMinDamage(minDamage);
        this.setMaxDamage(maxDamage);
        this.setSocketsCount(socketsCount);
    }

    public int getMinDamage() {
        return minDamage;
    }

    private void setMinDamage(int minDamage) {
        this.minDamage = minDamage;
    }

    public int getMaxDamage() {
        return maxDamage;
    }

    private void setMaxDamage(int maxDamage) {
        this.maxDamage = maxDamage;
    }

    public int getSocketsCount() {
        return socketsCount;
    }

    private void setSocketsCount(int socketsCount) {
        this.socketsCount = socketsCount;
    }
}

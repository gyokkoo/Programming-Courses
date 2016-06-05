package _14_DragonArmy;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class DragonArmy {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        LinkedHashMap<String, TreeMap<String, DragonStats>> dragonsData = new LinkedHashMap<>();
        int countOfDragons = Integer.parseInt(scanner.nextLine());
        for (int i = 0; i < countOfDragons; i++) {
            String[] tokens = scanner.nextLine().split(" ");
            String color = tokens[0];
            String dragonName = tokens[1];
            String damage = tokens[2];
            String health = tokens[3];
            String armor = tokens[4];
            DragonStats dragonStats = new DragonStats(damage, health, armor);

            if (!dragonsData.containsKey(color)) {
                dragonsData.put(color, new TreeMap<>());
            }

            dragonsData.get(color).put(dragonName, dragonStats);
        }

        for (Map.Entry<String, TreeMap<String, DragonStats>> dragonEntry : dragonsData.entrySet()) {
            System.out.print(dragonEntry.getKey());
            DragonStats.printAverageStats(dragonEntry.getValue());
            dragonEntry.getValue()
                    .entrySet()
                    .forEach(entry -> System.out.printf("-%s -> %s%n", entry.getKey(), entry.getValue()));
        }
    }
}

class DragonStats {
    private final int DEFAULT_DAMAGE = 45;
    private final int DEFAULT_HEALTH = 250;
    private final int DEFAULT_ARMOR = 10;

    private int damage;
    private int health;
    private int armor;

    DragonStats(String damage, String health, String armor) {
        this.setDamage(damage);
        this.setHealth(health);
        this.setArmor(armor);
    }

    private void setDamage(String damage) {
        if (damage.equals("null")) {
            this.damage = DEFAULT_DAMAGE;
            return;
        }
        this.damage = Integer.parseInt(damage);
    }

    private void setHealth(String health) {
        if (health.equals("null")) {
            this.health = DEFAULT_HEALTH;
            return;
        }
        this.health = Integer.parseInt(health);
    }

    private void setArmor(String armor) {
        if (armor.equals("null")) {
            this.armor = DEFAULT_ARMOR;
            return;
        }
        this.armor = Integer.parseInt(armor);
    }

    static void printAverageStats(TreeMap<String, DragonStats> data) {
        double sumDamage = 0;
        double sumHealth = 0;
        double sumArmor = 0;
        for (Map.Entry<String, DragonStats> stats : data.entrySet()) {
            sumDamage += stats.getValue().damage;
            sumHealth += stats.getValue().health;
            sumArmor += stats.getValue().armor;
        }

        System.out.printf("::(%.2f/%.2f/%.2f)%n",
                sumDamage / data.size(), sumHealth / data.size(), sumArmor / data.size());
    }

    @Override
    public String toString() {
        return "damage: " + damage +
                ", health: " + health +
                ", armor: " + armor;
    }
}
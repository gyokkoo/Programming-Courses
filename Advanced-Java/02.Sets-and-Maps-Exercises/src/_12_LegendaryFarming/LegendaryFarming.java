package _12_LegendaryFarming;

import java.util.*;

public class LegendaryFarming {
    private static final HashMap LEGENDARY_ITEMS = new HashMap<String, String>() {
        {
            put("shards", "Shadowmourne");
            put("fragments", "Valanyr");
            put("motes", "Dragonwrath");
        }
    };
    private static final Integer REQUIRED_MARKS = 250;

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        TreeMap<String, Integer> junkMaterials = new TreeMap<>();
        TreeMap<String, Integer> keyMaterials = new TreeMap<>();
        keyMaterials.put("shards", 0);
        keyMaterials.put("fragments", 0);
        keyMaterials.put("motes", 0);

        while (true) {
            String[] tokens = scanner.nextLine().split("\\s+");
            for (int i = 0; i < tokens.length - 1; i += 2) {
                int quantity = Integer.parseInt(tokens[i]);
                String material = tokens[i + 1].toLowerCase();

                if (keyMaterials.containsKey(material)) {
                    quantity += keyMaterials.get(material);
                    if (quantity >= REQUIRED_MARKS) {
                        String item = LEGENDARY_ITEMS.get(material).toString();
                        System.out.printf("%s obtained!%n", item);
                        keyMaterials.put(material, quantity - REQUIRED_MARKS);
                        printResult(keyMaterials, junkMaterials);
                        return;
                    }

                    keyMaterials.put(material, quantity);
                } else {
                    if (!junkMaterials.containsKey(material)) {
                        junkMaterials.put(material, 0);
                    }

                    quantity += junkMaterials.get(material);
                    junkMaterials.put(material, quantity);
                }
            }
        }
    }

    private static void printResult(TreeMap<String, Integer> keyMaterials, TreeMap<String, Integer> junkMaterials) {
        keyMaterials.entrySet()
                .stream()
                .sorted((m1, m2) -> m2.getValue().compareTo(m1.getValue()))
                .forEach(entry -> System.out.printf("%s: %d%n", entry.getKey(), entry.getValue()));

        junkMaterials.entrySet()
                .stream()
                .forEach(entry -> System.out.printf("%s: %d%n", entry.getKey(), entry.getValue()));
    }
}
package _06_MinerTask;

import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class MinerTask {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        LinkedHashMap<String, Long> resources = new LinkedHashMap<>();

        String line = scanner.nextLine();
        while (!"stop".equals(line)) {
            String resourceName = line;
            long quantity = Long.parseLong(scanner.nextLine());

            if (!resources.containsKey(resourceName)) {
                resources.put(resourceName, 0L);
            }

            quantity += resources.get(resourceName);
            resources.put(resourceName, quantity);

            line = scanner.nextLine();
        }

        for (Map.Entry<String, Long> resource : resources.entrySet()) {
            System.out.printf("%s -> %d%n", resource.getKey(), resource.getValue());
        }
    }
}

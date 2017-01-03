package _4_CubicAssault;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.TreeMap;

public class CubicAssault {

    private static final String END_MESSAGE = "Count em all";

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        TreeMap<String, TreeMap<String, Long>> meteors = new TreeMap<>();

        String line;
        while (!END_MESSAGE.equals(line = reader.readLine())) {
            String[] data = line.split(" -> ");
            String regionName = data[0];
            String meteorType = data[1];
            long count = Long.parseLong(data[2]);

            if (!meteors.containsKey(regionName)) {
                meteors.put(regionName, new TreeMap<>());
                meteors.get(regionName).put("Red", 0L);
                meteors.get(regionName).put("Black", 0L);
                meteors.get(regionName).put("Green", 0L);
            }

            count += meteors.get(regionName).get(meteorType);
            if (count >= 1000000) {
                if (meteorType.equals("Green")) {
                    meteors.get(regionName).put("Green", 0L);
                    long redCount = count / 1000000 + meteors.get(regionName).get("Red");
                    count %= 1000000;
                    meteors.get(regionName).put("Red", redCount);
                    if (redCount >= 1000000) {
                        meteors.get(regionName).put("Red", 0L);
                        long blackCount = redCount / 1000000;
                        long oldBlackCount = meteors.get(regionName).get("Black");
                        meteors.get(regionName).put("Black", blackCount + oldBlackCount);
                        continue;
                    }
                } else if (meteorType.equals("Red")) {
                    meteors.get(regionName).put("Red", 0L);
                    long blackCount = count / 1000000;
                    count %= 1000000;
                    long oldBlackCount = meteors.get(regionName).get("Black");
                    meteors.get(regionName).put("Black", blackCount + oldBlackCount);
                }
            }

            meteors.get(regionName).put(meteorType, count);
        }

        //Regions ordered by the amount of Black Meteors - descending
        //then by the length of their names - ascending and alphabetically (TreeSet)
        //for every region -> amount of units in them - descending and alphabetically
        meteors.entrySet().stream()
                .sorted((m1, m2) -> Integer.compare(m1.getKey().length(), m2.getKey().length()))
                .sorted((m1, m2) -> Long.compare(m2.getValue().get("Black"), m1.getValue().get("Black")))
                .forEach(entry -> {
                    System.out.println(entry.getKey());
                    entry.getValue().entrySet().stream()
                            .sorted((m1, m2) -> Long.compare(m2.getValue(), m1.getValue()))
                            .forEach(innerEntry ->
                                    System.out.printf("-> %s : %s%n", innerEntry.getKey(), innerEntry.getValue()));
                });
    }
}
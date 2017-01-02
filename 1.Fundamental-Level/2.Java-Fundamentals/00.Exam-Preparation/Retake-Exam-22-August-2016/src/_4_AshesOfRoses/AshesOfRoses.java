package _4_AshesOfRoses;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Comparator;
import java.util.Map;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class AshesOfRoses {

    private static final String END_MESSAGE = "Icarus, Ignite!";

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        TreeMap<String, TreeMap<String, Long>> roses = new TreeMap<>();
        Pattern pattern = Pattern.compile("\\b^Grow\\s<([A-Z][a-z]+)>\\s<([A-Za-z0-9]+)>\\s(\\d+)$");
        String line;
        while (!END_MESSAGE.equals(line = reader.readLine())) {
            Matcher matcher = pattern.matcher(line);
            while (matcher.find()) {
                String regionName = matcher.group(1);
                String colorName = matcher.group(2);
                Long roseCount = Long.parseLong(matcher.group(3));

                if (!roses.containsKey(regionName)) {
                    roses.put(regionName, new TreeMap<>());
                }

                if (!roses.get(regionName).containsKey(colorName)) {
                    roses.get(regionName).put(colorName, 0L);
                }

                Long count = roses.get(regionName).get(colorName);
                roses.get(regionName).put(colorName, roseCount + count);
            }
        }

        roses.entrySet()
                .stream()
                .sorted((r1, r2) -> Long.compare(r2.getValue().values().stream().mapToLong(Long::longValue).sum(),
                        r1.getValue().values().stream().mapToLong(Long::longValue).sum()))
                .forEach(entry -> {
                    System.out.println(entry.getKey());
                    entry.getValue().entrySet()
                            .stream()
                            .sorted(Comparator.comparingLong(Map.Entry::getValue))
                            .forEach(
                                    innerEntry ->
                                            System.out.printf("*--%s | %d%n", innerEntry.getKey(), innerEntry
                                                    .getValue()));
                });
    }
}
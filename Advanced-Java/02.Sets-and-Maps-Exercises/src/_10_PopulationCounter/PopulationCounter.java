package _10_PopulationCounter;

import java.util.*;

public class PopulationCounter {
    private static final String END_COMMAND = "report";

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        LinkedHashMap<String, LinkedHashMap<String, Long>> populationData = new LinkedHashMap<>();
        while (true) {
            String[] tokens = scanner.nextLine().split("\\|");
            if (END_COMMAND.equals(tokens[0])) {
                break;
            }

            String city = tokens[0];
            String country = tokens[1];
            Long population = Long.parseLong(tokens[2]);

            if (!populationData.containsKey(country)) {
                populationData.put(country, new LinkedHashMap<>());
            }

            populationData.get(country).put(city, population);
        }

        TreeMap<String, Long> countryPopulation = new TreeMap<>();
        for (Map.Entry<String, LinkedHashMap<String, Long>> countryEntry : populationData.entrySet()) {
            long totalPopulation = 0;
            for (Map.Entry<String, Long> cityEntry : countryEntry.getValue().entrySet()) {
                totalPopulation += cityEntry.getValue();
            }

            countryPopulation.put(countryEntry.getKey(), totalPopulation);
        }

        populationData.entrySet()
                .stream()
                .sorted((c1, c2) -> countryPopulation.get(c2.getKey()).compareTo(countryPopulation.get(c1.getKey())))
                .forEach(countryEntry -> {
                    String country = countryEntry.getKey();
                    System.out.printf("%s (total population: %d)%n", country, countryPopulation.get(country));

                    countryEntry.getValue()
                            .entrySet()
                            .stream()
                            .sorted((c1, c2) -> c2.getValue().compareTo(c1.getValue()))
                            .forEach(city -> System.out.printf("=>%s: %d%n", city.getKey(), city.getValue()));
                });
    }
}
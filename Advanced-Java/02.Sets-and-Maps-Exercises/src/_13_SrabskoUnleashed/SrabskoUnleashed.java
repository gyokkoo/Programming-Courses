package _13_SrabskoUnleashed;

import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class SrabskoUnleashed {
    private static final String END_MESSAGE = "End";
    private static final String REGEX = "(.+) @(.+) (\\d+) (\\d+)";

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        LinkedHashMap<String, LinkedHashMap<String, Long>> venueData = new LinkedHashMap<>();
        while (true) {
            String line = scanner.nextLine();
            if (END_MESSAGE.equals(line)) {
                break;
            }

            Pattern pattern = Pattern.compile(REGEX);
            Matcher matcher = pattern.matcher(line);
            if (matcher.find()) {
                String singer = matcher.group(1);
                String venue = matcher.group(2);
                Long ticketsPrice = Long.parseLong(matcher.group(3));
                Long ticketsCount = Long.parseLong(matcher.group(4));

                if (!venueData.containsKey(venue)) {
                    venueData.put(venue, new LinkedHashMap<>());
                }

                if (!venueData.get(venue).containsKey(singer)) {
                    venueData.get(venue).put(singer, 0L);
                }

                long money = venueData.get(venue).get(singer);
                venueData.get(venue).put(singer, money + ticketsCount * ticketsPrice);
            }
        }

        venueData.entrySet()
                .stream()
                .forEach(venue -> {
                    System.out.println(venue.getKey());
                    venue.getValue()
                            .entrySet()
                            .stream()
                            .sorted((v1, v2) -> v2.getValue().compareTo(v1.getValue()))
                            .forEach(singer -> System.out.printf("#  %s -> %d%n", singer.getKey(), singer.getValue()));
                });
    }
}
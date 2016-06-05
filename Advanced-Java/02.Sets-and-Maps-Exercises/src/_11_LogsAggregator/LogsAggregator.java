package _11_LogsAggregator;

import java.util.*;

public class LogsAggregator {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        HashMap<String, TreeSet<String>> userIpData = new HashMap<>();
        TreeMap<String, Integer> userDurationData = new TreeMap<>();
        int countOfLines = Integer.parseInt(scanner.nextLine());
        for (int i = 0; i < countOfLines; i++) {
            String[] tokens = scanner.nextLine().split("\\s+");

            String ip = tokens[0];
            String user = tokens[1];
            int duration = Integer.parseInt(tokens[2]);

            if (!userIpData.containsKey(user)) {
                userIpData.put(user, new TreeSet<>());
            }

            if (!userDurationData.containsKey(user)) {
                userDurationData.put(user, 0);
            }
            userIpData.get(user).add(ip);

            duration += userDurationData.get(user);
            userDurationData.put(user, duration);
        }

        for (Map.Entry<String, Integer> userDuration : userDurationData.entrySet()) {
            String user = userDuration.getKey();
            System.out.printf("%s: %d ", user, userDuration.getValue());
            System.out.println(userIpData.get(user));
        }
    }
}
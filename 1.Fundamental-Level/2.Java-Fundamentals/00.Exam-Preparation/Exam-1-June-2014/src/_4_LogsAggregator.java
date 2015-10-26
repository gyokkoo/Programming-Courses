import java.util.*;
//https://judge.softuni.bg/Contests/Practice/Index/14#3

public class _4_LogsAggregator {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());

        TreeMap<String, Integer> durations = new TreeMap<>();
        HashMap<String, TreeSet<String>> ipAddresses = new HashMap<>();
        for (int i = 0; i < n; i++) {
            String[] information = scanner.nextLine().split(" ");
            String ip = information[0];
            String user = information[1];
            int duration = Integer.parseInt(information[2]);

            Integer oldDuration = durations.get(user);
            if(oldDuration == null) {
                oldDuration = 0;
            }
            durations.put(user, oldDuration + duration);

            TreeSet<String> ipSet = ipAddresses.get(user);
            if(ipSet == null) {
                ipSet = new TreeSet<>();
            }
            ipSet.add(ip);
            ipAddresses.put(user, ipSet);
        }

        for (Map.Entry<String, Integer> userAndDuration : durations.entrySet()) {
            String user = userAndDuration.getKey();
            int duration = userAndDuration.getValue();
            TreeSet<String> ipSet = ipAddresses.get(user);
            System.out.printf("%s: %d %s%n", user, duration, ipSet);
        }
    }
}

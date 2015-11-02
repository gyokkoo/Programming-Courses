import java.util.*;
//https://judge.softuni.bg/Contests/Practice/Index/14#3

public class _4_LogsAggregator {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());


        TreeMap<String, Integer> durations = new TreeMap<>();
        TreeMap<String, TreeSet<String>> ipAddresses = new TreeMap<>();
        for (int i = 0; i < n; i++) {
            String[] lineArgs = scanner.nextLine().split(" ");
            String user = lineArgs[1];
            String ipAddress = lineArgs[0];
            int duration = Integer.parseInt(lineArgs[2]);

            if(!durations.containsKey(user)) {
                durations.put(user, duration);
            } else {
                duration += durations.get(user);
                durations.put(user, duration);
            }

            TreeSet<String> ipSet = ipAddresses.get(user);
            if(ipSet == null) {
                ipSet = new TreeSet<>();
            }
            ipSet.add(ipAddress);
            ipAddresses.put(user, ipSet);
        }

        for (Map.Entry<String, Integer> entry : durations.entrySet()) {
            System.out.printf("%s: %d ", entry.getKey(), entry.getValue());
            System.out.println(ipAddresses.get(entry.getKey()));
        }
    }
}

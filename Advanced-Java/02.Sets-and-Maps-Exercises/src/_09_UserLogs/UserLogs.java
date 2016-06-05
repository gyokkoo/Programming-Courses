package _09_UserLogs;

import java.util.*;

public class UserLogs {
    private static final String END_COMMAND = "end";

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        TreeMap<String, LinkedHashMap<String, Integer>> userLogs = new TreeMap<>();

        while (true) {
            String line = scanner.nextLine();
            if (line.equals(END_COMMAND)) {
                break;
            }

            String[] lineArgs = line.split(" ");
            String ip = lineArgs[0].split("=")[1];
            String user = lineArgs[2].split("=")[1];

            if (!userLogs.containsKey(user)) {
                userLogs.put(user, new LinkedHashMap<>());
            }

            if (!userLogs.get(user).containsKey(ip)) {
                userLogs.get(user).put(ip, 0);
            }

            int messagesCount = userLogs.get(user).get(ip) + 1;
            userLogs.get(user).put(ip, messagesCount);
        }

        for (Map.Entry<String, LinkedHashMap<String, Integer>> entry : userLogs.entrySet()) {
            System.out.println(entry.getKey() + ":");

            ArrayList<String> result = new ArrayList<>();
            for (Map.Entry<String, Integer> innerEntry : entry.getValue().entrySet()) {
                result.add(innerEntry.getKey() + " => " + innerEntry.getValue());
            }
            System.out.println(String.join(", ", result) + ".");
        }
    }
}

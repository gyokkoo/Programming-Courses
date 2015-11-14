import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _4_UserLogs {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String line = scanner.nextLine();
        TreeMap<String, LinkedHashMap<String, Integer>> userLogs = new TreeMap<>();
        while (!line.equals("end")) {
            Pattern pattern = Pattern.compile("IP=([^\\s+]+).*user=(\\w+)");
            Matcher matcher = pattern.matcher(line);
            while(matcher.find()) {
                String ip = matcher.group(1);
                String user = matcher.group(2);

                if(!userLogs.containsKey(user)) {
                    userLogs.put(user, new LinkedHashMap<>());
                    userLogs.get(user).put(ip, 1);
                } else {
                    if(!userLogs.get(user).containsKey(ip)) {
                        userLogs.get(user).put(ip,1);
                    } else {
                        int count = userLogs.get(user).get(ip);
                        userLogs.get(user).put(ip, count+1);
                    }
                }
            }
            line = scanner.nextLine();
        }

        for (Map.Entry<String, LinkedHashMap<String, Integer>> entry : userLogs.entrySet()) {
            System.out.println(entry.getKey() + ": ");
            List<String> output = new ArrayList<>();
            for (Map.Entry<String,Integer> innterEntry : entry.getValue().entrySet()) {
                output.add(innterEntry.getKey() + " => " + innterEntry.getValue());
            }
            System.out.println(String.join(", ", output) + ".");
        }
    }
}

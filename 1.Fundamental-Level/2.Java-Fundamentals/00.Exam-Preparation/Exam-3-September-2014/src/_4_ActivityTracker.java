import java.util.Iterator;
import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class _4_ActivityTracker {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());

        TreeMap<Integer, TreeMap<String, Integer>> tracker = new TreeMap<>();

        for (int i = 0; i < n; i++) {
            String[] inputLine = scanner.nextLine().split(" ");
            String[] date = inputLine[0].split("/");
            int month = Integer.parseInt(date[1]);
            String name = inputLine[1];
            int distance = Integer.parseInt(inputLine[2]);

            if(!tracker.containsKey(month)) {
                TreeMap<String, Integer> users = new TreeMap<>();
                users.put(name, distance);
                tracker.put(month, users);
            } else {
                TreeMap<String, Integer> users = tracker.get(month);
                if(!users.containsKey(name)) {
                    users.put(name, distance);
                } else {
                    int tempDistance = users.get(name);
                    tempDistance += distance;
                    users.put(name, tempDistance);
                }
                tracker.put(month, users);
            }
        }

        for (Iterator it = tracker.entrySet().iterator(); it.hasNext();) {
            Map.Entry month = (Map.Entry) it.next();

            String outputLine = month.getKey() + ": ";

            TreeMap users = (TreeMap) month.getValue();
            for (Iterator it2 = users.entrySet().iterator(); it2.hasNext();) {
                Map.Entry user = (Map.Entry) it2.next();

                outputLine += user.getKey() + "(" + user.getValue() + "), ";
            }

            outputLine = outputLine.substring(0, outputLine.length() - 2);
            System.out.println(outputLine);
        }
    }
}
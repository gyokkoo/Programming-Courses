package problem_4_;

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class FourthProblem {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        String line = scanner.nextLine();
      //  TreeMap<String, String> projects = new TreeMap<>();
        TreeMap<String, TreeMap<String, Integer>> errors = new TreeMap<>();
        TreeMap<String, TreeMap<String, List<String>>> messages = new TreeMap();
        while(!line.equals("END")) {
            Pattern pattern = Pattern.compile("\".*?\":\\s+\\[\"(.*?)\"],\\s+\"Type\":\\s+\\[\"(.*?)\"],\\s+\"Message\":\\s+\\[\"(.*?)\"]");
            Matcher matcher = pattern.matcher(line);

            while (matcher.find()) {
                String project = matcher.group(1);
                String type = matcher.group(2);
                String message = matcher.group(3);

                if(!errors.containsKey(project)) {
                    errors.put(project, new TreeMap<>());
                    errors.get(project).put("Critical", 0);
                    errors.get(project).put("Warning", 0);
                } else {
                    int oldValue = errors.get(project).get(type);
                    errors.get(project).put(type, oldValue + 1);
                }


                if(!messages.containsKey(project)) {
                    messages.put(project, new TreeMap<>());
                    List<String> messagesList = new ArrayList<>();
                    messagesList.add(message);
                    messages.get(project).put(type, messagesList);
                } else {

                }
            }
        }
    }
}

import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _4_GUnit {
    private static final String END_MESSAGE = "It's testing time!";
    private static final String PATTERN = "^([A-Z][A-Za-z0-9]+) \\| ([A-Z][A-Za-z0-9]+) \\| ([A-Z][A-Za-z0-9]+)$";

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        TreeMap<String, TreeMap<String, TreeSet<String>>> database = new TreeMap<>();
        String line = scanner.nextLine();
        while (!END_MESSAGE.equals(line)) {
            Pattern regex = Pattern.compile(PATTERN);
            Matcher matcher = regex.matcher(line);

            if (matcher.find()) {
                String className = matcher.group(1);
                String methodName = matcher.group(2);
                String testName = matcher.group(3);

                if (!database.containsKey(className)) {
                    database.put(className, new TreeMap<>());
                }

                if (!database.get(className).containsKey(methodName)) {
                    database.get(className).put(methodName, new TreeSet<>());
                }

                database.get(className).get(methodName).add(testName);
            }

            line = scanner.nextLine();
        }

        TreeMap<String, Integer> classTotalTests = new TreeMap<>();
        for (Map.Entry<String, TreeMap<String, TreeSet<String>>> classEntry : database.entrySet()) {
            int totalTests = 0;
            for (Map.Entry<String, TreeSet<String>> method : classEntry.getValue().entrySet()) {
                totalTests += method.getValue().size();
            }

            classTotalTests.put(classEntry.getKey(), totalTests);
        }

        database.entrySet()
                .stream()
                .sorted((c1, c2) -> Integer.compare(c1.getValue().size(), c2.getValue().size()))
                .sorted((c1, c2) -> classTotalTests.get(c2.getKey()).compareTo(classTotalTests.get(c1.getKey())))
                .forEach(classEntry -> {
                    System.out.println(classEntry.getKey() + ":");

                    classEntry.getValue()
                            .entrySet()
                            .stream()
                            .sorted((m1, m2) -> Integer.compare(m2.getValue().size(), m1.getValue().size()))
                            .forEach(method -> {
                                System.out.println("##" + method.getKey());
                                method.getValue()
                                        .stream()
                                        .sorted((t1, t2) -> Integer.compare(t1.length(), t2.length()))
                                        .forEach(test ->
                                                System.out.println("####" + test)
                                        );
                            });
                });
    }
}

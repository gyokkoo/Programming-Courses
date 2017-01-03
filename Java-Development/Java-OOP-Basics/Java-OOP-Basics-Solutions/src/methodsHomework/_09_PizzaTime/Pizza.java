package methodsHomework._09_PizzaTime;

import java.util.ArrayList;
import java.util.TreeMap;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Pizza {
    private Integer group;
    private String name;

    public Pizza(Integer group, String name) {
        this.group = group;
        this.name = name;
    }

    public static TreeMap<Integer, ArrayList<String>> procceed(String... pizzaInfo) {
        Pattern pattern = Pattern.compile("(\\d+)(\\w+)");
        TreeMap<Integer, ArrayList<String>> map = new TreeMap<>();

        for (String pizza : pizzaInfo) {
            Matcher matcher = pattern.matcher(pizza);
            if (matcher.find()) {
                Integer group = Integer.valueOf(matcher.group(1));
                String name = matcher.group(2);
                if (!map.containsKey(group)) {
                    map.put(group, new ArrayList<>());
                }
                map.get(group).add(name);
            }
        }

        return map;
    }
}

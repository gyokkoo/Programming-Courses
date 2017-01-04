package _13_OfficeStuff;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.LinkedHashMap;
import java.util.List;
import java.util.Map;
import java.util.TreeMap;
import java.util.stream.Collectors;

public class OfficeStuff {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        int n = Integer.parseInt(reader.readLine());

        TreeMap<String, LinkedHashMap<String, Integer>> companies = new TreeMap<>();
        for (int i = 0; i < n; i++) {
            String inputLine = reader.readLine();
            inputLine = inputLine.replaceAll("\\|", "");
            inputLine = inputLine.replaceAll(" ", "");
            String[] lineArgs = inputLine.split("-");

            String company = lineArgs[0];
            int amount = Integer.parseInt(lineArgs[1]);
            String product = lineArgs[2];

            if (!companies.containsKey(company)) {
                companies.put(company, new LinkedHashMap<>());
                companies.get(company).put(product, amount);
            } else {
                if (!companies.get(company).containsKey(product)) {
                    companies.get(company).put(product, amount);
                } else {
                    amount += companies.get(company).get(product);
                    companies.get(company).put(product, amount);
                }
            }
        }

        for (Map.Entry<String, LinkedHashMap<String, Integer>> entry : companies.entrySet()) {
            System.out.print(entry.getKey() + ": ");
            List<String> output = entry.getValue().entrySet()
                    .stream()
                    .map(entry2 -> entry2.getKey() + "-" + entry2.getValue())
                    .collect(Collectors.toList());
            System.out.println(String.join(", ", output));
        }
    }
}

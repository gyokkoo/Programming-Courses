import java.util.*;

public class _4_OfficeStuff {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());

        TreeMap<String, LinkedHashMap<String, Integer>> companies = new TreeMap<>();
        for (int i = 0; i < n; i++) {
            String inputLine = scanner.nextLine();
            inputLine = inputLine.replaceAll("\\|", "");
            inputLine = inputLine.replaceAll(" ", "");
            String[] lineArgs = inputLine.split("-");

            String company = lineArgs[0];
            int amount = Integer.parseInt(lineArgs[1]);
            String product = lineArgs[2];

            if(!companies.containsKey(company)) {
                companies.put(company, new LinkedHashMap<>());
                companies.get(company).put(product, amount);
            } else {
                if(!companies.get(company).containsKey(product)) {
                    companies.get(company).put(product, amount);
                } else {
                    amount += companies.get(company).get(product);
                    companies.get(company).put(product, amount);
                }
            }
        }

        for (Map.Entry<String, LinkedHashMap<String, Integer>> entry : companies.entrySet()) {
            System.out.print(entry.getKey() + ": ");
            List<String> output = new ArrayList<>();
            for (Map.Entry<String, Integer> entry2 : entry.getValue().entrySet()) {
                output.add(entry2.getKey() + "-" + entry2.getValue());
            }
            System.out.println(String.join(", ", output));
        }
    }
}

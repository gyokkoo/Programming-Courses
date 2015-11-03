import java.util.*;

public class _4_Nuts {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());

        TreeMap<String, LinkedHashMap<String, Integer>> nutsData = new TreeMap<>();
        for (int i = 0; i < n; i++) {
            String[] lineArgs = scanner.nextLine().split(" ");
            String company = lineArgs[0];
            String nut = lineArgs[1];
            int amount = Integer.parseInt(lineArgs[2].substring(0,lineArgs[2].length() - 2));

            if(!nutsData.containsKey(company)) {
                nutsData.put(company, new LinkedHashMap<>());
                nutsData.get(company).put(nut, amount);
            } else {
                if(!nutsData.get(company).containsKey(nut)) {
                    nutsData.get(company).put(nut, amount);
                } else {
                    amount += nutsData.get(company).get(nut);
                    nutsData.get(company).put(nut, amount);
                }
            }
        }

        for (Map.Entry<String, LinkedHashMap<String, Integer>> entry : nutsData.entrySet()) {
            System.out.print(entry.getKey() + ": ");
            List<String> nutsAmount = new ArrayList<>();
            for (Map.Entry<String, Integer> entry2 : entry.getValue().entrySet()) {
                nutsAmount.add(entry2.getKey() + "-" + entry2.getValue() + "kg");
            }
            System.out.println(String.join(", ", nutsAmount));
        }
    }
}

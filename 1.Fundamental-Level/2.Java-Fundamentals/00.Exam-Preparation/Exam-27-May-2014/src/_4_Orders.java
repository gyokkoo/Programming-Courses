import javax.transaction.TransactionRequiredException;
import java.util.*;

public class _4_Orders {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = Integer.parseInt(scanner.nextLine());

        LinkedHashMap<String, TreeMap<String, Integer>> orders = new LinkedHashMap<>();
        for (int i = 0; i < n; i++) {
            String[] inputArgs = scanner.nextLine().split(" ");
            String customer = inputArgs[0];
            int amount = Integer.parseInt(inputArgs[1]);
            String product = inputArgs[2];

            if(!orders.containsKey(product)) {
                TreeMap<String, Integer> customers = new TreeMap<>();
                customers.put(customer, amount);
                orders.put(product, customers);
            } else {
                if(!orders.get(product).containsKey(customer)) {
                    orders.get(product).put(customer, amount);
                } else {
                    amount += orders.get(product).get(customer);
                    orders.get(product).put(customer, amount);
                }
            }
        }
        for (Map.Entry<String, TreeMap<String, Integer>> entry : orders.entrySet()) {
            System.out.print(entry.getKey() + ": ");
            List<String> outputList = new ArrayList<>();
            for (Map.Entry<String, Integer> entry2 : entry.getValue().entrySet()) {
                outputList.add(String.format("%s %d", entry2.getKey(), entry2.getValue()));
            }
            System.out.println(String.join(", ", outputList));
        }
    }
}

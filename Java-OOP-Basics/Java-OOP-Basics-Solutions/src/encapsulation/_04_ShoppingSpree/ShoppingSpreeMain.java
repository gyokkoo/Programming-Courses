package encapsulation._04_ShoppingSpree;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.HashMap;
import java.util.LinkedHashMap;

public class ShoppingSpreeMain {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        try {
            LinkedHashMap<String, Person> peopleByName = new LinkedHashMap<>();
            String[] people = reader.readLine().split(";");
            for (String personInfo : people) {
                String[] personArgs = personInfo.split("=");
                String personName = personArgs[0];
                Double money = Double.valueOf(personArgs[1]);
                Person person = new Person(personName, money);
                peopleByName.put(personName, person);
            }

            HashMap<String, Product> productsByName = new HashMap<>();
            String[] products = reader.readLine().split(";");
            for (String productInfo : products) {
                String[] productArgs = productInfo.split("=");
                String productName = productArgs[0];
                Double productCost = Double.valueOf(productArgs[1]);
                Product product = new Product(productName, productCost);
                productsByName.put(productName, product);
            }

            while (true) {
                String[] lineArgs = reader.readLine().split(" ");
                if (lineArgs[0].equals("END")) {
                    break;
                }

                Person person = peopleByName.get(lineArgs[0]);
                Product product = productsByName.get(lineArgs[1]);
                String result = person.buy(product);
                System.out.println(result);
            }

            peopleByName.values().forEach(System.out::println);

        } catch (IllegalArgumentException iae) {
            System.out.println(iae.getMessage());
        }
    }
}

package staticMembers._04_BeerCount;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class BeerCountMain {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        while (true) {
            String[] tokens = reader.readLine().split(" ");
            if (tokens[0].equals("End")) {
                break;
            }

            long bottlesToBuy = Long.parseLong(tokens[0]);
            long bottlesToDrink = Long.parseLong(tokens[1]);
            BeerCounter.buyBeer(bottlesToBuy);
            BeerCounter.drinkBeer(bottlesToDrink);
        }

        System.out.printf("%d %d%n", BeerCounter.getBeerInStock(), BeerCounter.getBeersDrankCount());
    }
}

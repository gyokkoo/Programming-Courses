package definingClassesHomework._11_CatLady;

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.util.HashMap;

public class CatLadyMain {

    public static void main(String[] args) throws Exception {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        HashMap<String, Cat> cats = new HashMap<>();
        while (true) {
            String line = reader.readLine();
            if ("End".equals(line)) {
                break;
            }

            String[] tokens = line.split(" ");
            String breed = tokens[0];
            String name = tokens[1];
            double stats = Double.valueOf(tokens[2]);

            Cat cat = null;
            switch (breed) {
                case "Siamese":
                    cat = new Siamese(name, stats);
                    break;
                case "Cymric":
                    cat = new Cymric(name, stats);
                    break;
                case "StreetExtraordinaire":
                    cat = new StreetExtraordinaire(name, stats);
                    break;
            }
            cats.put(name, cat);
        }

        String searchedCatName = reader.readLine();
        System.out.println(cats.get(searchedCatName));
    }
}

package definingClassesHomework._08_PokemonTrainer;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.LinkedHashMap;

public class PokemonTrainerMain {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        LinkedHashMap<String, Trainer> trainers = new LinkedHashMap<>();
        while (true) {
            String[] tokens = reader.readLine().split(" ");
            if (tokens[0].equals("Tournament")) {
                break;
            }

            String trainerName = tokens[0];
            String pokemonName = tokens[1];
            String pokemonElement = tokens[2];
            int pokemonHealth = Integer.parseInt(tokens[3]);
            Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
            if (!trainers.containsKey(trainerName)) {
                trainers.put(trainerName, new Trainer(trainerName, pokemon));
            } else {
                trainers.get(trainerName).addPokemon(pokemon);
            }
        }

        while (true) {
            String element = reader.readLine();
            if (element.equals("End")) {
                break;
            }

            for (Trainer trainer : trainers.values()) {
                trainer.checkPokemon(element);
            }
        }

        trainers.entrySet().stream()
                .sorted((t1, t2) -> Integer.compare(t2.getValue().getNumberOfBadges(), t1.getValue().getNumberOfBadges()))
                .forEach(trainer -> System.out.println(trainer.getValue()));
    }
}
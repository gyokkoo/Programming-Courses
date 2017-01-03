package definingClassesHomework._08_PokemonTrainer;

import java.util.ArrayList;
import java.util.List;

public class Trainer {
    private static int HEALTH_LOSE = 10;
    private String name;
    private List<Pokemon> pokemons;
    private int numberOfBadges;

    public Trainer(String name, Pokemon pokemon) {
        this.name = name;
        this.numberOfBadges = 0;
        this.pokemons = new ArrayList<>();
        this.addPokemon(pokemon);
    }

    public int getNumberOfBadges() {
        return numberOfBadges;
    }

    public void addPokemon(Pokemon pokemon) {
        this.pokemons.add(pokemon);
    }

    public void checkPokemon(String element) {
        for (Pokemon pokemon : pokemons) {
            if (pokemon.getElement().equals(element)) {
                this.numberOfBadges++;
                return;
            }
        }

        List<Pokemon> pokemonsToRemove = new ArrayList<>();
        for (Pokemon pokemon : this.pokemons) {
            pokemon.reduceHealth(HEALTH_LOSE);
            if (!pokemon.isAlive()) {
                pokemonsToRemove.add(pokemon);
            }
        }

        pokemonsToRemove.stream().forEach(pokemon -> this.pokemons.remove(pokemon));
    }

    @Override
    public String toString() {
        return String.format("%s %d %d", this.name, this.numberOfBadges, this.pokemons.size());
    }
}



package definingClassesHomework._08_PokemonTrainer;

public class Pokemon {
    private String name;
    private String element;
    private int health;
    private boolean isAlive;

    public Pokemon(String name, String element, int health) {
        this.name = name;
        this.element = element;
        this.health = health;
        this.isAlive = true;
    }

    public String getElement() {
        return element;
    }

    public void reduceHealth(int health) {
        this.health -= health;
        if (this.health <= 0) {
            this.isAlive = false;
        }
    }

    public boolean isAlive() {
        return isAlive;
    }
}

package definingClassesHomework._09_Google;

import java.util.ArrayList;
import java.util.List;

public class Person {
    private String name;
    private Company company;
    private List<Pokemon> pokemons;
    private List<Parent> parents;
    private List<Child> children;
    private Car car;

    public Person(String name) {
        this.name = name;
        this.pokemons = new ArrayList<>();
        this.parents = new ArrayList<>();
        this.children = new ArrayList<>();
    }

    public void setCompany(Company company) {
        this.company = company;
    }

    public void setCar(Car car) {
        this.car = car;
    }

    public void addPokemon(Pokemon pokemon) {
        this.pokemons.add(pokemon);
    }

    public void addParent(Parent parent) {
        this.parents.add(parent);
    }

    public void addChild(Child child) {
        this.children.add(child);
    }

    @Override
    public String toString() {
        StringBuilder result = new StringBuilder();
        result.append(this.name).append(System.lineSeparator());
        result.append("Company:").append(System.lineSeparator());
        if (this.company != null) {
            result.append(this.company).append(System.lineSeparator());
        }
        result.append("Car:").append(System.lineSeparator());
        if (this.car != null) {
            result.append(this.car).append(System.lineSeparator());
        }
        result.append("Pokemon:").append(System.lineSeparator());
        for (Pokemon pokemon : pokemons) {
            result.append(pokemon).append(System.lineSeparator());
        }
        result.append("Parents:").append(System.lineSeparator());
        for (Parent parent : parents) {
            result.append(parent).append(System.lineSeparator());
        }
        result.append("Children:").append(System.lineSeparator());
        for (Child child : children) {
            result.append(child).append(System.lineSeparator());
        }

        return result.toString();
    }
}

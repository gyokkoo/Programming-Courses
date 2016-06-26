package definingClassesHomework._09_Google;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.HashMap;

public class GoogleMain {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        HashMap<String, Person> people = new HashMap<>();
        while (true) {
            String[] tokens = reader.readLine().split(" ");
            if (tokens[0].equals("End")) {
                break;
            }

            String personName = tokens[0];
            if (!people.containsKey(personName)) {
                people.put(personName, new Person(personName));
            }
            Person person = people.get(personName);
            String informationType = tokens[1];
            switch (informationType) {
                case "company":
                    String companyName = tokens[2];
                    String department = tokens[3];
                    Double salary = Double.valueOf(tokens[4]);
                    Company company = new Company(companyName, department, salary);
                    person.setCompany(company);
                    break;
                case "pokemon":
                    String pokemonName = tokens[2];
                    String pokemonType = tokens[3];
                    Pokemon pokemon = new Pokemon(pokemonName, pokemonType);
                    person.addPokemon(pokemon);
                    break;
                case "parents":
                    String parentName = tokens[2];
                    String parentBirthday = tokens[3];
                    Parent parent = new Parent(parentName, parentBirthday);
                    person.addParent(parent);
                    break;
                case "children":
                    String childName = tokens[2];
                    String childBirthday = tokens[3];
                    Child child = new Child(childName, childBirthday);
                    person.addChild(child);
                    break;
                case "car":
                    String carModel = tokens[2];
                    Integer carSpeed = Integer.valueOf(tokens[3]);
                    Car car = new Car(carModel, carSpeed);
                    person.setCar(car);
                    break;
            }
        }

        String personName = reader.readLine();
        System.out.print(people.get(personName));
    }
}

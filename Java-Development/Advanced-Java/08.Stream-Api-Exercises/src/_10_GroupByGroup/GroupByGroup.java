package _10_GroupByGroup;

import java.util.*;
import java.util.stream.Collectors;

public class GroupByGroup {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        List<Person> people = new ArrayList<>();
        String line = null;
        while (!Objects.equals(line = scanner.nextLine(), "END")) {
            String[] data = line.split(" ");
            String name = data[0] + " " + data[1];
            Integer group = Integer.parseInt(data[2]);

            Person person = new Person(name, group);
            people.add(person);
        }

        Map<Integer, List<Person>> groupedPeople = people
                .stream()
                .collect(Collectors.groupingBy(Person::getGroup));

        groupedPeople
                .entrySet().forEach(person -> {
            System.out.print(person.getKey() + " - ");
            System.out.println(person.getValue().stream().map(Object::toString).collect(Collectors.joining(", ")));
        });
    }
}

class Person {

    private String name;
    private Integer group;

    public Person(String name, Integer group) {
        this.name = name;
        this.group = group;
    }

    public String getName() {
        return name;
    }

    public Integer getGroup() {
        return group;
    }

    @Override
    public String toString() {
        return name;
    }
}
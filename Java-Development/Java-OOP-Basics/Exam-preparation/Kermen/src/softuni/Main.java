package softuni;

import softuni.homes.Household;
import softuni.homes.HouseholdFactory;
import softuni.items.Toy;
import softuni.people.Child;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        City kermen = new City();
        HouseholdFactory householdFactory = new HouseholdFactory();

        int count = 0;
        String line = null;
        while (!(line = reader.readLine()).equals("Democracy")) {
            count++;
            if (line.equals("EVN")) {
                parseEvnCommand(kermen, count);
                continue;
            } else if (line.equals("EVN bill")) {
                parseEvnBillCommand(kermen, count);
                continue;
            }

            parseHomeCommand(kermen, householdFactory, count, line);
        }

        System.out.printf("Total population: %d%n", kermen.getPopulation());
    }

    private static void parseHomeCommand(City kermen, HouseholdFactory householdFactory, int count, String line) {
        String[] childParts = line.split(" Child");
        String command = childParts[0].substring(0, childParts[0].indexOf('('));
        Pattern pattern = Pattern.compile("[\\d.]+");
        Matcher matcher = pattern.matcher(childParts[0]);

        List<String> householdArgs = parseHomeArguments(command, matcher);
        List<Child> children = new ArrayList<>();
        parseChildren(childParts, pattern, children);

        Household household = householdFactory.createHousehold(householdArgs, children);
        kermen.addHousehold(household);
        tryPaySalaries(count, kermen);
    }

    private static List<String> parseHomeArguments(String command, Matcher matcher) {
        List<String> householdArgs = new ArrayList<>();
        householdArgs.add(command);
        while (matcher.find()) {
            householdArgs.add(matcher.group());
        }
        return householdArgs;
    }

    private static void parseChildren(String[] childParts, Pattern pattern, List<Child> children) {
        Matcher matcher;
        for (int i = 1; i < childParts.length; i++) {
            matcher = pattern.matcher(childParts[i]);
            matcher.find();
            double foodCost = Double.parseDouble(matcher.group());
            List<Toy> toys = new ArrayList<>();
            while (matcher.find()) {
                double toyCost = Double.parseDouble(matcher.group());
                Toy toy = new Toy(toyCost);
                toys.add(toy);
            }

            Child child = new Child(foodCost, toys);
            children.add(child);
        }
    }

    private static void parseEvnBillCommand(City kermen, int count) {
        tryPaySalaries(count, kermen);
        kermen.payBills();
    }

    private static void parseEvnCommand(City kermen, int count) {
        tryPaySalaries(count, kermen);
        System.out.println("Total consumption: " + kermen.getConsumption());
    }

    private static void tryPaySalaries(int lineCount, City city) {
        if (lineCount % 3 == 0) {
            city.receiveSalaries();
        }
    }
}
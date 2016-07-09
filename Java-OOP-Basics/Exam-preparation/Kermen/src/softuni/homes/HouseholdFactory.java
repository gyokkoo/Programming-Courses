package softuni.homes;

import softuni.items.Device;
import softuni.people.Child;
import softuni.people.Person;

import java.util.List;

public class HouseholdFactory {

    public Household createHousehold(List<String> householdArgs, List<Child> children) {
        String homeType = householdArgs.get(0);
        Double[] arguments = householdArgs
                .stream()
                .skip(1)
                .map(Double::parseDouble)
                .toArray(Double[]::new);
        Household household = null;
        switch (homeType) {
            case "YoungCouple":
                household = new YoungCoupleHome(
                        new Person(arguments[0]),
                        new Person(arguments[1]),
                        new Device(arguments[2]),
                        new Device(arguments[3]),
                        new Device(arguments[4])
                );
                break;
            case "YoungCoupleWithChildren":
                household = new YoungCoupleChildrenHome(
                        new Person(arguments[0]),
                        new Person(arguments[1]),
                        new Device(arguments[2]),
                        new Device(arguments[3]),
                        new Device(arguments[4]),
                        children
                );
                break;
            case "AloneYoung":
                household = new AloneYoungHome(
                        new Person(arguments[0]),
                        new Device(arguments[1])
                );
                break;
            case "OldCouple":
                household = new OldCoupleHome(
                        new Person(arguments[0]),
                        new Person(arguments[1]),
                        new Device(arguments[2]),
                        new Device(arguments[3]),
                        new Device(arguments[4])
                );
                break;
            case "AloneOld":
                household = new AloneOldHome(
                        new Person(arguments[0])
                );
                break;
            default:
                break;
        }

        household.addRooms();
        household.calculateSalaries();
        household.calculateBills();
        return household;
    }
}

package softuni.homes;

import softuni.items.Device;
import softuni.people.Person;

public class OldCoupleHome extends Household {
    private static final int ROOMS_COUNT = 3;
    private static final int ROOMS_CONSUMPTION = 15;

    public OldCoupleHome(Person male, Person female, Device tv, Device fridge, Device stove) {
        super();
        this.people.add(male);
        this.people.add(female);
        this.devices.add(tv);
        this.devices.add(fridge);
        this.devices.add(stove);
    }

    @Override
    public void addRooms() {
        super.addRooms(ROOMS_COUNT, ROOMS_CONSUMPTION);
    }
}
package softuni.homes;

import softuni.items.Device;
import softuni.people.Person;

public class YoungCoupleHome extends Household {
    private static final int ROOMS_COUNT = 2;
    private static final int ROOMS_CONSUMPTION = 20;

    public YoungCoupleHome(Person male, Person female, Device tv, Device fridge, Device laptop) {
        super();
        this.people.add(male);
        this.people.add(female);
        this.devices.add(tv);
        this.devices.add(fridge);
        this.devices.add(laptop);
        this.devices.add(laptop);
    }

    @Override
    public void addRooms() {
        super.addRooms(ROOMS_COUNT, ROOMS_CONSUMPTION);
    }
}

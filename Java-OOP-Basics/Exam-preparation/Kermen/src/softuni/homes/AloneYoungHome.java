package softuni.homes;

import softuni.items.Device;
import softuni.people.Person;

public class AloneYoungHome extends Household {
    private static final int ROOMS_COUNT = 1;
    private static final int ROOMS_CONSUMPTION = 10;

    public AloneYoungHome(Person person, Device laptop) {
        super();
        this.devices.add(laptop);
    }

    @Override
    public void addRooms() {
        super.addRooms(ROOMS_COUNT, ROOMS_CONSUMPTION);
    }
}
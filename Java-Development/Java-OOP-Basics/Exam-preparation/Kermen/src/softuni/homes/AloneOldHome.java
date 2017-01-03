package softuni.homes;

import softuni.people.Person;

public class AloneOldHome extends Household {
    private static final int ROOMS_COUNT = 1;
    private static final int ROOMS_CONSUMPTION = 15;

    public AloneOldHome(Person person) {
        super();
        this.people.add(person);
    }

    @Override
    public void addRooms() {
        super.addRooms(ROOMS_COUNT, ROOMS_CONSUMPTION);
    }
}

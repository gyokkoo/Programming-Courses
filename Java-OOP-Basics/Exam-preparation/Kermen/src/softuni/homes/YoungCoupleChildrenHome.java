package softuni.homes;

import softuni.items.Device;
import softuni.people.Child;
import softuni.people.Person;

import java.util.List;

public class YoungCoupleChildrenHome extends YoungCoupleHome {
    private static final int ROOMS_COUNT = 2;
    private static final int ROOMS_CONSUMPTION = 30;

    public YoungCoupleChildrenHome(Person male,
                                   Person female,
                                   Device tv,
                                   Device fridge,
                                   Device laptop,
                                   List<Child> children) {
        super(male, female, tv, fridge, laptop);
        this.children.addAll(children);
    }

    @Override
    public void addRooms() {
        super.addRooms(ROOMS_COUNT, ROOMS_CONSUMPTION);
    }
}

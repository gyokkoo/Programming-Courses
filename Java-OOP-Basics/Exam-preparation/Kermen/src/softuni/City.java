package softuni;

import softuni.homes.Household;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class City {
    private List<Household> households;

    public City() {
        this.households = new ArrayList<>();
    }

    public void addHousehold(Household household) {
        this.households.add(household);
    }

    public void removeHousehold(Household household) {
        this.households.remove(household);
    }

    public int getPopulation() {
        return this.households.stream().mapToInt(Household::getPeopleCount).sum();
    }

    public double getConsumption() {
        return this.households.stream().mapToDouble(Household::getConsumption).sum();
    }

    public void payBills() {
        Iterator<Household> iterator = this.households.iterator();
        while (iterator.hasNext()) {
            Household currentHousehold = iterator.next();
            if (!currentHousehold.payBills()) {
                iterator.remove();
            }
        }
    }

    public void receiveSalaries() {
        this.households.forEach(Household::receiveSalary);
    }
}

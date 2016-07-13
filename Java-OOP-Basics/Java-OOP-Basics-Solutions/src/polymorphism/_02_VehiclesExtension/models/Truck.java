package polymorphism._02_VehiclesExtension.models;

import java.text.DecimalFormat;

public class Truck extends Vehicle {
    private static final double AIR_CONDITIONER_CONSUMPTION = 1.6;

    private static final double FUEL_LOST = 0.95;

    public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) {
        super(fuelQuantity, fuelConsumption, tankCapacity);
    }

    @Override
    public String drive(double distance) {
        String result = null;
        double fuelNeed = distance * (this.getFuelConsumption() + AIR_CONDITIONER_CONSUMPTION);
        if (fuelNeed <= this.getFuelQuantity()) {
            this.setFuelQuantity(this.getFuelQuantity() - fuelNeed);
            result = String.format("Truck travelled %s km", new DecimalFormat("0.########").format(distance));
        } else {
            result = "Truck needs refueling";
        }

        return result;
    }

    @Override
    public void refuel(double liters) {
        double fuel = this.getFuelQuantity() + liters * FUEL_LOST;
        this.setFuelQuantity(fuel);
    }
}

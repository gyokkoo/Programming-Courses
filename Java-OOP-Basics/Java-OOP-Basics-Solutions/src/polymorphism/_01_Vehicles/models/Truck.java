package polymorphism._01_Vehicles.models;

import java.text.DecimalFormat;

public class Truck extends Vehicle {
    private static final double AIR_CONDITIONER_CONSUMPTION = 1.6;

    private static final double FEUL_LOST = 0.95;

    public Truck(double fuelQuantity, double fuelConsumption) {
        super(fuelQuantity, fuelConsumption);
    }

    @Override
    public String drive(double distance) {
        String result = null;
        double fuelNeed = distance * (this.getFuelConsumption() + AIR_CONDITIONER_CONSUMPTION);
        if (fuelNeed <= this.getFuelQuantity()) {
            this.setFuelQuantity(this.getFuelQuantity() - fuelNeed);
            this.setDistance(this.getDistance() + distance);
            result = String.format("Truck travelled %s km", new DecimalFormat("0.########").format(distance));
        } else {
            result = "Truck needs refueling";
        }

        return result;
    }

    @Override
    public void refuel(double liters) {
        double fuel = this.getFuelQuantity() + liters * FEUL_LOST;
        this.setFuelQuantity(fuel);
    }
}

package polymorphism._01_Vehicles.models;

import java.text.DecimalFormat;

public class Car extends Vehicle {
    private static final double AIR_CONDITIONER_CONSUMPTION = 0.9;

    public Car(double fuelQuantity, double fuelConsumption) {
        super(fuelQuantity, fuelConsumption);
    }

    @Override
    public String drive(double distance) {
        String result = null;
        double fuelNeed = distance * (this.getFuelConsumption() + AIR_CONDITIONER_CONSUMPTION);
        if (fuelNeed <= this.getFuelQuantity()) {
            this.setFuelQuantity(this.getFuelQuantity() - fuelNeed);
            this.setDistance(this.getDistance() + distance);
            result = String.format("Car travelled %s km", new DecimalFormat("0.########").format(distance));
        } else {
            result = "Car needs refueling";
        }

        return result;
    }

    @Override
    public void refuel(double liters) {
        double fuel = this.getFuelQuantity() + liters;
        this.setFuelQuantity(fuel);
    }
}

package polymorphism._01_Vehicles.models;

public abstract class Vehicle {
    private double fuelQuantity;
    private double fuelConsumption; //in liters per km
    private double distance;

    public Vehicle(double fuelQuantity, double fuelConsumption) {
        this.setFuelQuantity(fuelQuantity);
        this.setFuelConsumption(fuelConsumption);
        this.distance = 0;
    }

    public abstract String drive(double distance);

    public abstract void refuel(double liters);

    public double getFuelQuantity() {
        return fuelQuantity;
    }

    public double getFuelConsumption() {
        return fuelConsumption;
    }

    public double getDistance() {
        return distance;
    }

    public void setDistance(double distance) {
        this.distance = distance;
    }

    public void setFuelQuantity(double fuelQuantity) {
        if (fuelQuantity < 0) {
            throw new IllegalArgumentException("Fuel quantity cannot be negative.");
        }

        this.fuelQuantity = fuelQuantity;
    }

    public void setFuelConsumption(double fuelConsumption) {
        if (fuelConsumption < 0) {
            throw new IllegalArgumentException("Fuel consumption cannot be negative");
        }

        this.fuelConsumption = fuelConsumption;
    }

    @Override
    public String toString() {
        return String.format("%s: %.2f", this.getClass().getSimpleName(), this.getFuelQuantity());
    }
}

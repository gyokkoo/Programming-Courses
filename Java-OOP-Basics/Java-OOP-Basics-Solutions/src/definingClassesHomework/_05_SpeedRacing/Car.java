package definingClassesHomework._05_SpeedRacing;

public class Car {
    private String model;
    private double fuelAmount;
    private double fuelCost;
    private double distanceTraveled;

    public Car(String model, double fuelAmount, double fuelCost) {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelCost = fuelCost;
    }

    public boolean drive(double amountOfKm) {
        double fuelNeed = amountOfKm * this.fuelCost;
        if (fuelAmount < fuelNeed) {
            return false;
        }

        this.fuelAmount -= fuelNeed;
        this.distanceTraveled += amountOfKm;
        return true;
    }

    @Override
    public String toString() {
        return String.format("%s %.2f %.0f", this.model, this.fuelAmount, this.distanceTraveled);
    }
}

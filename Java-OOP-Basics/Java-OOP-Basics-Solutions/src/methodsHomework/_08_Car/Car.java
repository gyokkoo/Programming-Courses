package methodsHomework._08_Car;

public class Car {
    private double speed;
    private double fuelAmount;
    private double fuelEconomy;
    private double distance;
    private double travelTime;

    public Car(double speed, double fuelAmount, double fuelEconomy) {
        this.speed = speed;
        this.fuelAmount = fuelAmount;
        this.fuelEconomy = fuelEconomy;
        this.distance = 0;
        this.travelTime = 0;
    }

    public double getDistance() {
        return distance;
    }

    public double getTravelTime() {
        return travelTime;
    }

    public double getFuelAmount() {
        return fuelAmount;
    }

    public void travel(double distance) {
        double maxDistance = this.fuelAmount * 100 / this.fuelEconomy;
        if (maxDistance > distance) {
            this.distance += distance;
            this.fuelAmount -= this.fuelEconomy * distance / 100;
        } else {
            distance = this.fuelAmount * 100 / this.fuelEconomy;
            this.distance += distance;
            this.fuelAmount = 0;
        }

        this.travelTime += distance / this.speed * 60;
    }

    public void refuel(double liters) {
        this.fuelAmount += liters;
    }
}

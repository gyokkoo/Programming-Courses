package softuni;

public class Room {
    private double consumption;

    public Room(double consumption) {
        this.setConsumption(consumption);
    }

    public double getConsumption() {
        return consumption;
    }

    private void setConsumption(double consumption) {
        this.consumption = consumption;
    }
}

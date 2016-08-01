package enumerationAndAnnotations._09_TrafficLights.enums;

public enum TrafficLight {
    RED,
    GREEN,
    YELLOW;

    private TrafficLight nextSignal;

    public TrafficLight getNextSignal() {
        return nextSignal;
    }

    public void setNextSignal(TrafficLight nextSignal) {
        this.nextSignal = nextSignal;
    }
}

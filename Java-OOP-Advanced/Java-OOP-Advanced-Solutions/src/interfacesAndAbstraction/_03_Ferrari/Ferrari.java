package interfacesAndAbstraction._03_Ferrari;

public class Ferrari implements Car {

    private static final String CAR_MODEL = "488-Spider";

    private String driverName;

    public Ferrari(String driverName) {
        this.setDriverName(driverName);
    }

    private static String getCarModel() {
        return CAR_MODEL;
    }

    private String getDriverName() {
        return driverName;
    }

    private void setDriverName(String driverName) {
        this.driverName = driverName;
    }

    @Override
    public String getModel() {
        return CAR_MODEL;
    }

    @Override
    public String useBrakes() {
        return "Brakes!";
    }

    @Override
    public String useGasPedal() {
        return "Zadu6avam sA!";
    }

    @Override
    public String toString() {
        return String.format("%s/%s/%s/%s",
                this.getModel(),
                this.useBrakes(),
                this.useGasPedal(),
                this.driverName);
    }
}

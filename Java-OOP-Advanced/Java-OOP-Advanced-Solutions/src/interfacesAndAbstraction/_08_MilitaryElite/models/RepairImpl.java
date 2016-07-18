package interfacesAndAbstraction._08_MilitaryElite.models;

import interfacesAndAbstraction._08_MilitaryElite.interfaces.Repair;

public class RepairImpl implements Repair {

    private String partName;
    private int workedHours;

    public RepairImpl(String partName, int workedHours) {
        this.setPartName(partName);
        this.setWorkedHours(workedHours);
    }

    public String getPartName() {
        return partName;
    }

    private void setPartName(String partName) {
        this.partName = partName;
    }

    public int getWorkedHours() {
        return workedHours;
    }

    private void setWorkedHours(int workedHours) {
        this.workedHours = workedHours;
    }

    @Override
    public String toString() {
        return String.format("  Part Name: %s Hours Worked: %d",
                this.getPartName(),
                this.getWorkedHours());
    }
}

package interfacesAndAbstraction._08_MilitaryElite.models;

import interfacesAndAbstraction._08_MilitaryElite.interfaces.Mission;

public class MissionImpl implements Mission {

    private String codeName;
    private String state;

    public MissionImpl(String codeName, String state) {
        this.setCodeName(codeName);
        this.setState(state);
    }

    @Override
    public String getCodeName() {
        return codeName;
    }

    private void setCodeName(String codeName) {
        this.codeName = codeName;
    }

    @Override
    public String getState() {
        return state;
    }

    @Override
    public void completeMission() {
        this.setState("Finished");
    }

    private void setState(String state) {
        if (!state.equals("Finished") && !state.equals("inProgress")) {
            throw new IllegalArgumentException("Invalid state");
        }

        this.state = state;
    }

    @Override
    public String toString() {
        return String.format("  Code Name: %s State: %s",
                this.getCodeName(),
                this.getState());
    }

}

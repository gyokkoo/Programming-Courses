package reflection._05_BarracksWarsReturnOfTheDependencies.core.commands;

import reflection._05_BarracksWarsReturnOfTheDependencies.contracts.Executable;

public abstract class Command implements Executable {

    private String[] data;

    protected Command(String[] data) {
        this.data = data;
    }

    protected String[] getData() {
        return data;
    }
}

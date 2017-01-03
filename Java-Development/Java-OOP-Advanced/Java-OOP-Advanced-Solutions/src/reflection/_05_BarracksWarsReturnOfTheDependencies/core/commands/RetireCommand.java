package reflection._05_BarracksWarsReturnOfTheDependencies.core.commands;

import reflection._05_BarracksWarsReturnOfTheDependencies.annotations.Inject;
import reflection._05_BarracksWarsReturnOfTheDependencies.contracts.Repository;

public class RetireCommand extends Command {

    @Inject
    private Repository repository;

    public RetireCommand(String[] data) {
        super(data);
    }

    @Override
    public String execute() {
        String unitType = this.getData()[1];
        this.repository.removeUnit(unitType);
        String output = unitType + " retired!";

        return output;
    }
}

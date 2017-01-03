package reflection._05_BarracksWarsReturnOfTheDependencies.core.commands;

import reflection._05_BarracksWarsReturnOfTheDependencies.annotations.Inject;
import reflection._05_BarracksWarsReturnOfTheDependencies.contracts.Repository;
import reflection._05_BarracksWarsReturnOfTheDependencies.contracts.Unit;
import reflection._05_BarracksWarsReturnOfTheDependencies.contracts.UnitFactory;

public class AddCommand extends Command {

    @Inject
    private UnitFactory unitFactory;

    @Inject
    private Repository repository;

    public AddCommand(String[] data) {
        super(data);
    }

    @Override
    public String execute() {
        String unitType = this.getData()[1];
        Unit unitToAdd = this.unitFactory.createUnit(unitType);
        this.repository.addUnit(unitToAdd);
        String output = unitType + " added!";

        return output;
    }
}

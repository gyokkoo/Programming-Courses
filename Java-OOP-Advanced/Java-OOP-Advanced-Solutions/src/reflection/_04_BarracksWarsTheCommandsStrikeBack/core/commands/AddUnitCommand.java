package reflection._04_BarracksWarsTheCommandsStrikeBack.core.commands;

import reflection._04_BarracksWarsTheCommandsStrikeBack.contracts.Repository;
import reflection._04_BarracksWarsTheCommandsStrikeBack.contracts.Unit;
import reflection._04_BarracksWarsTheCommandsStrikeBack.contracts.UnitFactory;

public class AddUnitCommand extends Command {

    public AddUnitCommand(String[] data, Repository repository, UnitFactory unitFactory) {
        super(data, repository, unitFactory);
    }

    @Override
    public String execute() {
        String unitType = this.getData()[1];
        Unit unitToAdd = this.getUnitFactory().createUnit(unitType);
        this.getRepository().addUnit(unitToAdd);
        String output = unitType + " added!";

        return output;
    }
}

package reflection._04_BarracksWarsTheCommandsStrikeBack.core.commands;

import reflection._04_BarracksWarsTheCommandsStrikeBack.contracts.Repository;
import reflection._04_BarracksWarsTheCommandsStrikeBack.contracts.UnitFactory;

public class RetireCommand extends Command {

    public RetireCommand(String[] data, Repository repository, UnitFactory unitFactory) {
        super(data, repository, unitFactory);
    }

    @Override
    public String execute() {
        String unitType = this.getData()[1];
        this.getRepository().removeUnit(unitType);
        String output = unitType + " retired!";

        return output;
    }
}

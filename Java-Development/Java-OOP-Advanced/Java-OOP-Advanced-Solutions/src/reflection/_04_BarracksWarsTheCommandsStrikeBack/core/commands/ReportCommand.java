package reflection._04_BarracksWarsTheCommandsStrikeBack.core.commands;

import reflection._04_BarracksWarsTheCommandsStrikeBack.contracts.Repository;
import reflection._04_BarracksWarsTheCommandsStrikeBack.contracts.UnitFactory;

public class ReportCommand extends Command {

    public ReportCommand(String[] data, Repository repository, UnitFactory unitFactory) {
        super(data, repository, unitFactory);
    }

    @Override
    public String execute() {
        String output = this.getRepository().getStatistics();
        return output;
    }
}

package reflection._05_BarracksWarsReturnOfTheDependencies.core.commands;

import reflection._05_BarracksWarsReturnOfTheDependencies.annotations.Inject;
import reflection._05_BarracksWarsReturnOfTheDependencies.contracts.Repository;

public class ReportCommand extends Command {

    @Inject
    private Repository repository;

    public ReportCommand(String[] data) {
        super(data);
    }

    @Override
    public String execute() {
        String output = this.repository.getStatistics();
        return output;
    }
}

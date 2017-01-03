package reflection._05_BarracksWarsReturnOfTheDependencies.core.commands;

public class FightCommand extends Command {

    public FightCommand(String[] data) {
        super(data);
    }

    @Override
    public String execute() {
        return "fight";
    }
}

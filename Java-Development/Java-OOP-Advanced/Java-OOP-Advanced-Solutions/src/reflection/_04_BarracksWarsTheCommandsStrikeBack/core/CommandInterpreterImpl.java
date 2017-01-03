package reflection._04_BarracksWarsTheCommandsStrikeBack.core;

import reflection._04_BarracksWarsTheCommandsStrikeBack.contracts.CommandInterpreter;
import reflection._04_BarracksWarsTheCommandsStrikeBack.contracts.Executable;
import reflection._04_BarracksWarsTheCommandsStrikeBack.contracts.Repository;
import reflection._04_BarracksWarsTheCommandsStrikeBack.contracts.UnitFactory;
import reflection._04_BarracksWarsTheCommandsStrikeBack.core.commands.AddUnitCommand;
import reflection._04_BarracksWarsTheCommandsStrikeBack.core.commands.FightCommand;
import reflection._04_BarracksWarsTheCommandsStrikeBack.core.commands.ReportCommand;
import reflection._04_BarracksWarsTheCommandsStrikeBack.core.commands.RetireCommand;

public class CommandInterpreterImpl implements CommandInterpreter {

    private Repository repository;
    private UnitFactory unitFactory;

    public CommandInterpreterImpl(Repository repository, UnitFactory unitFactory) {
        this.repository = repository;
        this.unitFactory = unitFactory;
    }

    public Executable interpretCommand(String[] data, String commandName) {
        Executable command = this.createCommand(data, commandName);
        return command;
    }

    private Executable createCommand(String[] data, String commandName) {
        Executable command = null;
        switch (commandName) {
            case "add":
                command = new AddUnitCommand(data, this.repository, this.unitFactory);
                break;
            case "report":
                command = new ReportCommand(data, this.repository, this.unitFactory);
                break;
            case "fight":
                command = new FightCommand(data, this.repository, this.unitFactory);
                break;
            case "retire":
                command = new RetireCommand(data, this.repository, this.unitFactory);
                break;
            default:
                throw new RuntimeException("Invalid command!");
        }

        return command;
    }
}

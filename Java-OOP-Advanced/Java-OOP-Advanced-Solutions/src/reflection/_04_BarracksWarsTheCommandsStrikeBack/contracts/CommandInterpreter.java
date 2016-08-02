package reflection._04_BarracksWarsTheCommandsStrikeBack.contracts;

public interface CommandInterpreter {

	Executable interpretCommand(String[] data, String commandName);
}

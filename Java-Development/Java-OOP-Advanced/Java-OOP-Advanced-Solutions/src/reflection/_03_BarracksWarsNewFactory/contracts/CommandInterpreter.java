package reflection._03_BarracksWarsNewFactory.contracts;

public interface CommandInterpreter {

	Executable interpretCommand(String[] data, String commandName);
}

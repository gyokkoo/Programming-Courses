package reflection._05_BarracksWarsReturnOfTheDependencies.contracts;

public interface CommandInterpreter {

	Executable interpretCommand(String[] data, String commandName);
}

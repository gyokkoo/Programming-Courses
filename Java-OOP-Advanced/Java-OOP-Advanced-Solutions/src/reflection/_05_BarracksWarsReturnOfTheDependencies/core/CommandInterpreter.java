package reflection._05_BarracksWarsReturnOfTheDependencies.core;

import reflection._05_BarracksWarsReturnOfTheDependencies.annotations.Inject;
import reflection._05_BarracksWarsReturnOfTheDependencies.contracts.Executable;
import reflection._05_BarracksWarsReturnOfTheDependencies.contracts.Interpreter;
import reflection._05_BarracksWarsReturnOfTheDependencies.contracts.Repository;
import reflection._05_BarracksWarsReturnOfTheDependencies.contracts.UnitFactory;

import java.lang.reflect.Constructor;
import java.lang.reflect.Field;

public class CommandInterpreter implements Interpreter {

    private static final String COMMANDS_PACKAGE =
            "reflection._05_BarracksWarsReturnOfTheDependencies.core.commands.";

    private Repository repository;
    private UnitFactory unitFactory;

    public CommandInterpreter(Repository repository, UnitFactory unitFactory) {
        this.repository = repository;
        this.unitFactory = unitFactory;
    }

    public String interpretCommand(String[] data, String commandName) {
        Executable executable = null;

        try {
            String className = Character.toUpperCase(commandName.charAt(0)) + commandName.substring(1) + "Command";
            Class executableClass = Class.forName(COMMANDS_PACKAGE + className);
            Constructor constructor = executableClass.getDeclaredConstructor(String[].class);
            constructor.setAccessible(true);
            executable = (Executable) constructor.newInstance((Object) data);
            this.injectDependencies(executable, executableClass);
        } catch (ReflectiveOperationException rfe) {
            rfe.printStackTrace();
        }

        String result = executable.execute();
        return result;
    }

    private void injectDependencies(Executable command, Class executableClass)
            throws ReflectiveOperationException {
        Field[] fields = executableClass.getDeclaredFields();
        Field[] theseField = CommandInterpreter.class.getDeclaredFields();

        for (Field fieldToSet : fields) {
            if (!fieldToSet.isAnnotationPresent(Inject.class)) {
                continue;
            }

            fieldToSet.setAccessible(true);
            for (Field thisField : theseField) {
                if (!thisField.getType().equals(fieldToSet.getType())) {
                    continue;
                }

                thisField.setAccessible(true);
                fieldToSet.set(command, thisField.get(this));
            }
        }
    }
}

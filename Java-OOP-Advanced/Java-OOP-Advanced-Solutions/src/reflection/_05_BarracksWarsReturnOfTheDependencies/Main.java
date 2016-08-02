package reflection._05_BarracksWarsReturnOfTheDependencies;

import reflection._05_BarracksWarsReturnOfTheDependencies.contracts.Interpreter;
import reflection._05_BarracksWarsReturnOfTheDependencies.contracts.Repository;
import reflection._05_BarracksWarsReturnOfTheDependencies.contracts.UnitFactory;
import reflection._05_BarracksWarsReturnOfTheDependencies.core.CommandInterpreter;
import reflection._05_BarracksWarsReturnOfTheDependencies.core.Engine;
import reflection._05_BarracksWarsReturnOfTheDependencies.core.factories.UnitFactoryImpl;
import reflection._05_BarracksWarsReturnOfTheDependencies.data.UnitRepository;

public class Main {

    public static void main(String[] args) {
        Repository repository = new UnitRepository();
        UnitFactory unitFactory = new UnitFactoryImpl();
        Interpreter commandInterpreter = new CommandInterpreter(repository, unitFactory);

        Runnable engine = new Engine(commandInterpreter);
        engine.run();
    }
}

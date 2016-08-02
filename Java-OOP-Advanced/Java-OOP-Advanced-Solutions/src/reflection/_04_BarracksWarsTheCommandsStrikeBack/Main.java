package reflection._04_BarracksWarsTheCommandsStrikeBack;

import reflection._04_BarracksWarsTheCommandsStrikeBack.contracts.CommandInterpreter;
import reflection._04_BarracksWarsTheCommandsStrikeBack.contracts.Repository;
import reflection._04_BarracksWarsTheCommandsStrikeBack.contracts.UnitFactory;
import reflection._04_BarracksWarsTheCommandsStrikeBack.core.CommandInterpreterImpl;
import reflection._04_BarracksWarsTheCommandsStrikeBack.core.Engine;
import reflection._04_BarracksWarsTheCommandsStrikeBack.core.factories.UnitFactoryImpl;
import reflection._04_BarracksWarsTheCommandsStrikeBack.data.UnitRepository;

public class Main {

    public static void main(String[] args) {
        Repository repository = new UnitRepository();
        UnitFactory unitFactory = new UnitFactoryImpl();
        CommandInterpreter commandInterpreter = new CommandInterpreterImpl(repository, unitFactory);

        Runnable engine = new Engine(commandInterpreter);
        engine.run();
    }
}

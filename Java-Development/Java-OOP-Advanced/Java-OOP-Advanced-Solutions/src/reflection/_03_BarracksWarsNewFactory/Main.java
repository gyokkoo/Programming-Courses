package reflection._03_BarracksWarsNewFactory;

import reflection._03_BarracksWarsNewFactory.contracts.Repository;
import reflection._03_BarracksWarsNewFactory.contracts.UnitFactory;
import reflection._03_BarracksWarsNewFactory.core.Engine;
import reflection._03_BarracksWarsNewFactory.core.factories.UnitFactoryImpl;
import reflection._03_BarracksWarsNewFactory.data.UnitRepository;

public class Main {

    public static void main(String[] args) {
        Repository repository = new UnitRepository();
        UnitFactory unitFactory = new UnitFactoryImpl();
        Runnable engine = new Engine(repository, unitFactory);
        engine.run();
    }
}

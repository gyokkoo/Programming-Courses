package reflection._04_BarracksWarsTheCommandsStrikeBack.core.commands;

import reflection._04_BarracksWarsTheCommandsStrikeBack.contracts.Executable;
import reflection._04_BarracksWarsTheCommandsStrikeBack.contracts.Repository;
import reflection._04_BarracksWarsTheCommandsStrikeBack.contracts.UnitFactory;

public abstract class Command implements Executable {

    private String[] data;
    private Repository repository;
    private UnitFactory unitFactory;

    protected Command(String[] data, Repository repository, UnitFactory unitFactory) {
        this.data = data;
        this.repository = repository;
        this.unitFactory = unitFactory;
    }

    protected String[] getData() {
        return data;
    }

    protected Repository getRepository() {
        return repository;
    }

    protected UnitFactory getUnitFactory() {
        return unitFactory;
    }
}

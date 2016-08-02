package reflection._04_BarracksWarsTheCommandsStrikeBack.core.factories;

import reflection._04_BarracksWarsTheCommandsStrikeBack.contracts.Unit;
import reflection._04_BarracksWarsTheCommandsStrikeBack.contracts.UnitFactory;

import java.lang.reflect.Constructor;

public class UnitFactoryImpl implements UnitFactory {

    private static final String UNITS_PACKAGE_NAME =
            "reflection._04_BarracksWarsTheCommandsStrikeBack.units.";

    @Override
    public Unit createUnit(String unitType) {
        Unit unit = null;
        try {
            Class<Unit> unitClass = (Class<Unit>) Class.forName(UNITS_PACKAGE_NAME + unitType);
            Constructor<Unit> constructor = unitClass.getDeclaredConstructor();
            unit = constructor.newInstance();
        } catch (ReflectiveOperationException rfe) {
            rfe.printStackTrace();
        }

        return unit;
    }
}

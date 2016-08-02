package reflection._05_BarracksWarsReturnOfTheDependencies.core.factories;

import reflection._05_BarracksWarsReturnOfTheDependencies.contracts.Unit;
import reflection._05_BarracksWarsReturnOfTheDependencies.contracts.UnitFactory;

import java.lang.reflect.Constructor;

public class UnitFactoryImpl implements UnitFactory {

    private static final String UNITS_PACKAGE_NAME =
            "reflection._05_BarracksWarsReturnOfTheDependencies.units.";

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

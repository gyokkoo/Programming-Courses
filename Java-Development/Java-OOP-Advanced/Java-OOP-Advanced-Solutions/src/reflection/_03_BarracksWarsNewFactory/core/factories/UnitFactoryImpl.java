package reflection._03_BarracksWarsNewFactory.core.factories;

import reflection._03_BarracksWarsNewFactory.contracts.Unit;
import reflection._03_BarracksWarsNewFactory.contracts.UnitFactory;

import java.lang.reflect.Constructor;

public class UnitFactoryImpl implements UnitFactory {

    private static final String UNITS_PACKAGE_NAME =
            "reflection._03_BarracksWarsNewFactory.models.units.";

    @Override
    public Unit createUnit(String unitType) {
        Unit unit = null;
        try {
            Class unitClass = Class.forName(UNITS_PACKAGE_NAME + unitType);
            Constructor constructor = unitClass.getDeclaredConstructor();
            unit = (Unit) constructor.newInstance();
        } catch (ReflectiveOperationException rfe) {
            rfe.printStackTrace();
        }

        return unit;
    }
}

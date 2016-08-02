package reflection._05_BarracksWarsReturnOfTheDependencies.contracts;

public interface Repository {

    void addUnit(Unit unit);

    String getStatistics();

    void removeUnit(String unitType);
}
package reflection._03_BarracksWarsNewFactory.contracts;

public interface Repository {

    void addUnit(Unit unit);

    String getStatistics();

    void removeUnit(String unitType);
}
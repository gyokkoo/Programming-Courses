package reflection._04_BarracksWarsTheCommandsStrikeBack.contracts;

public interface Repository {

    void addUnit(Unit unit);

    String getStatistics();

    void removeUnit(String unitType);
}
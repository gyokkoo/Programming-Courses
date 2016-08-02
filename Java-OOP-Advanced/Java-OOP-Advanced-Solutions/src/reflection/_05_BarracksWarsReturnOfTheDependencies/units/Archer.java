package reflection._05_BarracksWarsReturnOfTheDependencies.units;

public class Archer extends AbstractUnit {
    private static final int ARCHER_HEALHT = 25;
    private static final int ARCHER_DAMAGE = 7;

    public Archer() {
        super(ARCHER_HEALHT, ARCHER_DAMAGE);
    }
}

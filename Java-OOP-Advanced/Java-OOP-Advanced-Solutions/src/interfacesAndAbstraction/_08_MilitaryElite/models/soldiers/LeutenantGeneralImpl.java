package interfacesAndAbstraction._08_MilitaryElite.models.soldiers;

import interfacesAndAbstraction._08_MilitaryElite.interfaces.LeutenantGeneral;
import interfacesAndAbstraction._08_MilitaryElite.interfaces.Private;

import java.util.Collection;

public class LeutenantGeneralImpl extends PrivateImpl implements LeutenantGeneral {

    private Collection<Private> privateSoldiers;

    public LeutenantGeneralImpl(int id, String firstName, String lastName, double salary, Collection<Private>
            privateSoldiers) {
        super(id, firstName, lastName, salary);
        this.setPrivateSoldiers(privateSoldiers);
    }

    @Override
    public Collection<Private> getPrivateSoldiers() {
        return privateSoldiers;
    }

    private void setPrivateSoldiers(Collection<Private> privateSoldiers) {
        this.privateSoldiers = privateSoldiers;
    }

    @Override
    public String toString() {
        StringBuilder builder = new StringBuilder();

        builder.append(super.toString())
                .append(System.lineSeparator())
                .append("Privates:");

        for (Private privateSoldier : this.privateSoldiers) {
            builder.append(System.lineSeparator())
                    .append("  ")
                    .append(privateSoldier);
        }

        return builder.toString();
    }
}

package interfacesAndAbstraction._08_MilitaryElite.models.soldiers;

import interfacesAndAbstraction._08_MilitaryElite.interfaces.Commando;
import interfacesAndAbstraction._08_MilitaryElite.interfaces.Mission;

import java.util.Collection;

public class CommandoImpl extends SpecialisedSoldierImpl implements Commando {

    private Collection<Mission> missions;

    public CommandoImpl(int id, String firstName, String lastName, double salary, String corps, Collection<Mission>
            missions) {
        super(id, firstName, lastName, salary, corps);
        this.setMissions(missions);
    }

    @Override
    public Collection<Mission> getMissions() {
        return missions;
    }

    private void setMissions(Collection<Mission> missions) {
        this.missions = missions;
    }

    @Override
    public String toString() {
        StringBuilder builder = new StringBuilder();

        builder.append(super.toString())
                .append(System.lineSeparator())
                .append("Missions:");

        for (Mission mission : this.missions) {
            builder.append(System.lineSeparator())
                    .append(mission);
        }

        return builder.toString();
    }
}
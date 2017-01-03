package encapsulation._06_FootballTeamGenerator.models;

public class Player {
    private String name;
    private double endurance;
    private double sprint;
    private double dribble;
    private double passing;
    private double shooting;

    public Player(String name, double endurance, double sprint, double dribble, double passing, double shooting) {
        this.setName(name);
        this.setEndurance(endurance);
        this.setSprint(sprint);
        this.setDribble(dribble);
        this.setPassing(passing);
        this.setShooting(shooting);
    }

    public String getName() {
        return name;
    }

    public double getSkillLevel() {
        double sumStats = this.endurance + this.sprint + this.dribble + this.passing + this.shooting;
        return sumStats / 5;
    }

    private void setName(String name) {
        if (name == null || name.trim().length() == 0) {
            throw new IllegalArgumentException("A name should not be empty.");
        }

        this.name = name;
    }

    private void setEndurance(double endurance) {
        if (!isValidStat(endurance)) {
            throw new IllegalArgumentException("Endurance should be between 0 and 100.");
        }

        this.endurance = endurance;
    }

    private void setSprint(double sprint) {
        if (!isValidStat(sprint)) {
            throw new IllegalArgumentException("Sprint should be between 0 and 100.");
        }

        this.sprint = sprint;
    }

    private void setDribble(double dribble) {
        if (!isValidStat(dribble)) {
            throw new IllegalArgumentException("Dribble should be between 0 and 100.");
        }

        this.dribble = dribble;
    }

    private void setPassing(double passing) {
        if (!isValidStat(passing)) {
            throw new IllegalArgumentException("Passing should be between 0 and 100.");
        }

        this.passing = passing;
    }

    private void setShooting(double shooting) {
        if (!isValidStat(shooting)) {
            throw new IllegalArgumentException("Shooting should be between 0 and 100.");
        }

        this.shooting = shooting;
    }

    private boolean isValidStat(double stat) {
        return 0 <= stat && stat <= 100;
    }
}

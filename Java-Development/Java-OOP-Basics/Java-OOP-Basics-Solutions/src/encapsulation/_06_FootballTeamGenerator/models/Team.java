package encapsulation._06_FootballTeamGenerator.models;

import java.util.HashMap;

public class Team {
    private String name;
    private HashMap<String, Player> players;

    public Team(String name) {
        this.setName(name);
        this.players = new HashMap<>();
    }

    public String getName() {
        return name;
    }

    public void addPlayer(Player player) {
        this.players.put(player.getName(), player);
    }

    public void removePlayer(String playerName) {
        if (!this.players.containsKey(playerName)) {
            throw new IllegalArgumentException(
                    String.format("Player %s is not in %s team.", playerName, this.name));
        }

        this.players.remove(playerName);
    }

    public double getRating() {
        if (this.players.size() == 0) {
            return 0;
        }

        double total = 0;
        for (Player player : players.values()) {
            total += player.getSkillLevel();
        }

        return total / this.players.size();
    }

    private void setName(String name) {
        if (name == null || name.trim().length() == 0) {
            throw new IllegalArgumentException("A name should not be empty.");
        }

        this.name = name;
    }
}

package encapsulation._06_FootballTeamGenerator;

import encapsulation._06_FootballTeamGenerator.models.Player;
import encapsulation._06_FootballTeamGenerator.models.Team;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.HashMap;

public class Main {
    private static HashMap<String, Team> teams;

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        teams = new HashMap<>();
        while (true) {

            String[] lineArgs = reader.readLine().split(";");
            if (lineArgs[0].equals("END")) {
                break;
            }
            String command = lineArgs[0];
            String teamName = lineArgs[1];
            try {
                switch (command) {
                    case "Team":
                        Team team = tryCreateTeam(lineArgs);
                        teams.put(team.getName(), team);
                        break;
                    case "Add":
                        checkTeamExists(teamName);
                        Player player = tryCreatePlayer(lineArgs);
                        Team playerTeam = teams.get(teamName);
                        playerTeam.addPlayer(player);
                        break;
                    case "Remove":
                        String playerName = lineArgs[2];
                        checkTeamExists(teamName);
                        teams.get(teamName).removePlayer(playerName);
                        break;
                    case "Rating":
                        checkTeamExists(teamName);
                        System.out.printf("%s - %.0f%n", teamName, teams.get(teamName).getRating());
                        break;
                }
            } catch (IllegalArgumentException iae) {
                System.out.println(iae.getMessage());
            }
        }
    }

    private static void checkTeamExists(String teamName) {
        if (!teams.containsKey(teamName)) {
            throw new IllegalArgumentException(
                    String.format("Team %s does not exist.", teamName));
        }
    }

    private static Player tryCreatePlayer(String[] lineArgs) {
        String name = lineArgs[2];
        double endurance = Double.parseDouble(lineArgs[3]);
        double sprint = Double.parseDouble(lineArgs[4]);
        double dribble = Double.parseDouble(lineArgs[5]);
        double passing = Double.parseDouble(lineArgs[6]);
        double shooting = Double.parseDouble(lineArgs[7]);

        return new Player(name, endurance, sprint, dribble, passing, shooting);
    }

    private static Team tryCreateTeam(String[] lineArgs) {
        String teamName = lineArgs[1];

        return new Team(teamName);
    }
}
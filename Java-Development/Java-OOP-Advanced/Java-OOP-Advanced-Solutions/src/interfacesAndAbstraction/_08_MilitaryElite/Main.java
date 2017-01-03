package interfacesAndAbstraction._08_MilitaryElite;

import interfacesAndAbstraction._08_MilitaryElite.interfaces.*;
import interfacesAndAbstraction._08_MilitaryElite.models.MissionImpl;
import interfacesAndAbstraction._08_MilitaryElite.models.RepairImpl;
import interfacesAndAbstraction._08_MilitaryElite.models.soldiers.*;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.*;
import java.util.stream.Collectors;

public class Main {

    private static Map<Integer, Private> privateSoldiers;
    private static List<Soldier> soldiers;

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        privateSoldiers = new HashMap<>();
        soldiers = new LinkedList<>();

        while (true) {
            String[] lineTokens = reader.readLine().split(" ");
            if (lineTokens[0].equals("End")) {
                break;
            }

            try {
                executeCommand(lineTokens);
            } catch (IllegalArgumentException ignored) {
            }
        }

        soldiers.forEach(System.out::println);
    }

    private static void executeCommand(String[] lineTokens) {
        String soldierType = lineTokens[0];
        int id = Integer.parseInt(lineTokens[1]);
        String firstName = lineTokens[2];
        String lastName = lineTokens[3];
        switch (soldierType) {
            case "Private":
                double privateSalary = Double.parseDouble(lineTokens[4]);
                Private privateSoldier = new PrivateImpl(id, firstName, lastName, privateSalary);
                privateSoldiers.put(privateSoldier.getId(), privateSoldier);
                soldiers.add(privateSoldier);
                break;
            case "LeutenantGeneral":
                double generalSalary = Double.parseDouble(lineTokens[4]);

                List<Integer> privateSoldiersIds = Arrays.stream(lineTokens).skip(5).map(Integer::parseInt).collect
                        (Collectors.toList());
                List<Private> privateSoldiers = parsePrivateSoldiers(privateSoldiersIds);

                Soldier leutenantGeneral = new LeutenantGeneralImpl(id, firstName, lastName, generalSalary,
                        privateSoldiers);
                soldiers.add(leutenantGeneral);
                break;
            case "Engineer":
                double engineerSalary = Double.parseDouble(lineTokens[4]);
                String engineerCorps = lineTokens[5];

                List<String> repairsArgs = Arrays.stream(lineTokens).skip(6).collect(Collectors.toList());
                List<Repair> repairs = parseRepairs(repairsArgs);

                Soldier engineer = new EngineerImpl(id, firstName, lastName, engineerSalary, engineerCorps, repairs);
                soldiers.add(engineer);
                break;
            case "Commando":
                double commandoSalary = Double.parseDouble(lineTokens[4]);
                String commandoCorps = lineTokens[5];

                List<String> missionArgs = Arrays.stream(lineTokens).skip(6).collect(Collectors.toList());
                List<Mission> missions = parseMissions(missionArgs);

                Soldier commando = new CommandoImpl(id, firstName, lastName, commandoSalary, commandoCorps, missions);
                soldiers.add(commando);
                break;
            case "Spy":
                int codeNumber = Integer.parseInt(lineTokens[4]);
                Soldier spy = new SpyImpl(id, firstName, lastName, codeNumber);
                soldiers.add(spy);
                break;
            default:
                throw new IllegalArgumentException("Invalid soldier type");
        }
    }

    private static List<Mission> parseMissions(List<String> missionArgs) {
        List<Mission> missions = new ArrayList<>();
        for (int i = 0; i < missionArgs.size(); i += 2) {
            String missionCodeName = missionArgs.get(i);
            String missionState = missionArgs.get(i + 1);
            try {
                Mission mission = new MissionImpl(missionCodeName, missionState);
                missions.add(mission);
            } catch (IllegalArgumentException ignored) {
            }
        }

        return missions;
    }

    private static List<Repair> parseRepairs(List<String> repairsArgs) {
        List<Repair> repairs = new ArrayList<>();
        for (int i = 0; i < repairsArgs.size(); i += 2) {
            String repairPartName = repairsArgs.get(i);
            int workedHours = Integer.parseInt(repairsArgs.get(i + 1));
            Repair repair = new RepairImpl(repairPartName, workedHours);
            repairs.add(repair);
        }

        return repairs;
    }

    private static List<Private> parsePrivateSoldiers(List<Integer> privateSoldiersIds) {
        List<Private> privates = new ArrayList<>();
        for (Integer soldierId : privateSoldiersIds) {
            privates.add(privateSoldiers.get(soldierId));
        }

        return privates;
    }
}

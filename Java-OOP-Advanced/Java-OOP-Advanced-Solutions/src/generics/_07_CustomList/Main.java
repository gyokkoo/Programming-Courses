package generics._07_CustomList;

import generics._07_CustomList.interfaces.CustomList;
import generics._07_CustomList.models.CustomListImpl;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        CustomList<String> customList = new CustomListImpl<>();
        while (true) {
            String[] commandTokens = reader.readLine().split(" ");
            if (commandTokens[0].equals("END")) {
                break;
            }

            interpretCommand(customList, commandTokens);
        }
    }

    private static void interpretCommand(CustomList<String> customList, String[] commandTokens) {
        switch (commandTokens[0]) {
            case "Add":
                customList.add(commandTokens[1]);
                break;
            case "Remove":
                customList.remove(Integer.parseInt(commandTokens[1]));
                break;
            case "Contains":
                System.out.println(customList.contains(commandTokens[1]));
                break;
            case "Swap":
                customList.swap(Integer.parseInt(commandTokens[1]), Integer.parseInt(commandTokens[2]));
                break;
            case "Greater":
                System.out.println(customList.countGreaterThat(commandTokens[1]));
                break;
            case "Max":
                System.out.println(customList.getMax());
                break;
            case "Min":
                System.out.println(customList.getMin());
                break;
            case "Print":
                System.out.print(customList.toString());
                break;
            default:
                throw new IllegalArgumentException("Invalid command");
        }
    }
}

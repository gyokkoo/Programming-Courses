package _2_LittleAlchemy;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayDeque;
import java.util.Deque;

public class LittleAlchemy {
    private static final String END_COMMAND = "Revision";
    private static final String APPLY_ACID_COMMAND = "Apply";
    private static final String AIR_LEAK_COMMAND = "Air";

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String[] lineNumbers = reader.readLine().split("\\s+");
        Deque<Integer> stoneNumbers = new ArrayDeque<>();
        for (String numberStr : lineNumbers) {
            stoneNumbers.add(Integer.parseInt(numberStr));
        }

        int goldCounter = 0;
        String command = reader.readLine();
        while (!END_COMMAND.equals(command)) {
            String[] commandArgs = command.split("\\s+");
            String currentCommand = commandArgs[0];
            int n = Integer.parseInt(commandArgs[2]);
            if (APPLY_ACID_COMMAND.equals(currentCommand)) {
                for (int i = 0; i < n; i++) {
                    if (!stoneNumbers.isEmpty()) {
                        int element = stoneNumbers.poll() - 1;
                        if (element <= 0) {
                            goldCounter++;
                        } else {
                            stoneNumbers.addLast(element);
                        }
                    }
                }
            } else if (AIR_LEAK_COMMAND.equals(currentCommand) && goldCounter > 0) {
                stoneNumbers.add(n);
                goldCounter--;
            }

            command = reader.readLine();
        }

        System.out.println(stoneNumbers.toString().replaceAll("[\\[,\\]]", ""));
        System.out.println(goldCounter);
    }
}

package reflection._04_BarracksWarsTheCommandsStrikeBack.core;


import reflection._04_BarracksWarsTheCommandsStrikeBack.contracts.CommandInterpreter;
import reflection._04_BarracksWarsTheCommandsStrikeBack.contracts.Executable;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Engine implements Runnable {

    private CommandInterpreter commandInterpreter;

    public Engine(CommandInterpreter commandInterpreter) {
        this.commandInterpreter = commandInterpreter;
    }

    @Override
    public void run() {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        boolean isRunning = true;
        while (isRunning) {
            try {
                String input = reader.readLine();
                String[] data = input.split("\\s+");
                String commandName = data[0];
                Executable command = this.commandInterpreter.interpretCommand(data, commandName);
                String result = command.execute();
                if (result.equals("fight")) {
                    isRunning = false;
                } else {
                    System.out.println(result);
                }
            } catch (RuntimeException e) {
                System.out.println(e.getMessage());
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
    }
}
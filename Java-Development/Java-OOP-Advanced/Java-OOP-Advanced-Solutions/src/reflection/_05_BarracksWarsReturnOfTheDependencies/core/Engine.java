package reflection._05_BarracksWarsReturnOfTheDependencies.core;


import reflection._05_BarracksWarsReturnOfTheDependencies.contracts.Interpreter;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Engine implements Runnable {

    private Interpreter commandInterpreter;
    private boolean isRunning;

    public Engine(Interpreter commandInterpreter) {
        this.commandInterpreter = commandInterpreter;
    }

    @Override
    public void run() {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        this.isRunning = true;
        while (isRunning) {
            try {
                String input = reader.readLine();
                String[] data = input.split("\\s+");
                String commandName = data[0];
                String result = this.commandInterpreter.interpretCommand(data, commandName);
                if (result.equals("fight")) {
                    this.isRunning = false;
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
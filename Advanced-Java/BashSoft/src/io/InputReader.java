package io;

import staticData.SessionData;

import java.io.BufferedReader;
import java.io.InputStreamReader;

public class InputReader {
    private static final String END_COMMAND = "quit";

    public static void readCommands() throws Exception {
        OutputWriter.writeMessageOnNewLine(String.format("%s > ", SessionData.currentPath));

        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String input = reader.readLine().trim();

        while (!END_COMMAND.equals(input)) {
            CommandInterpreter.interpretCommand(input);
            input = reader.readLine().trim();
        }

        Thread[] threads = new Thread[Thread.activeCount()];
        Thread.enumerate(threads);
        for (Thread thread : threads) {
            if (!thread.getName().equals("main") && !thread.isDaemon()) {
                thread.join();
            }
        }

    }
}

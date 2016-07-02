package io;

import java.util.ArrayList;

public class OutputWriter {
    public static void writeMessageOnNewLine(String message) {
        System.out.println(message);
    }

    public static void writeMessage(String message) {
        System.out.print(message);
    }

    public static void displayException(String message) {
        System.out.println(message);
    }

    public static void printStudent(String name, ArrayList<Integer> marks) {
        String output = String.format("%s - %s", name, marks.toString());
        OutputWriter.writeMessageOnNewLine(output);
    }

    public static void writeEmptyLine() {
        System.out.println();
    }
}

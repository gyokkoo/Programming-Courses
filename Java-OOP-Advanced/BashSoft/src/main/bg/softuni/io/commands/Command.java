package main.bg.softuni.io.commands;

import main.bg.softuni.exceptions.InvalidInputException;
import main.bg.softuni.contracts.Executable;

public abstract class Command implements Executable {

    private String input;
    private String[] data;

    protected Command(String input, String[] data) {
        this.setInput(input);
        this.setData(data);
    }

    protected String getInput() {
        return input;
    }

    private void setInput(String input) {
        if (input == null || input.equals("")) {
            throw new InvalidInputException(this.input);
        }
        this.input = input;
    }

    protected String[] getData() {
        return data;
    }

    private void setData(String[] data) {
        if (data == null || data.length < 1) {
            throw new InvalidInputException(this.input);
        }
        this.data = data;
    }

    public abstract void execute() throws Exception;
}

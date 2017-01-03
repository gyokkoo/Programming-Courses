package main.bg.softuni.io.commands;

import main.bg.softuni.annotations.Alias;
import main.bg.softuni.contracts.ContentComparer;
import main.bg.softuni.exceptions.InvalidInputException;

@Alias("cmp")
public class CompareFilesCommand extends Command {

    private ContentComparer tester;

    public CompareFilesCommand(String input, String[] data) {
        super(input, data);
    }

    @Override
    public void execute() throws Exception {
        String[] data = this.getData();
        if (data.length != 3) {
            throw new InvalidInputException(this.getInput());
        }

        String firstPath = data[1];
        String secondPath = data[2];
        this.tester.compareContent(firstPath, secondPath);
    }
}

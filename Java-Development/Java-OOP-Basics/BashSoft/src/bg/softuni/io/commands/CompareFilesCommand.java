package bg.softuni.io.commands;

import bg.softuni.exceptions.InvalidCommandException;
import bg.softuni.io.IOManager;
import bg.softuni.judge.Tester;
import bg.softuni.network.DownloadManager;
import bg.softuni.repository.StudentsRepository;

public class CompareFilesCommand extends Command {

    public CompareFilesCommand(String input,
                               String[] data,
                               StudentsRepository repository,
                               Tester tester,
                               IOManager ioManager,
                               DownloadManager downloadManager) {
        super(input, data, repository, tester, ioManager, downloadManager);
    }

    @Override
    public void execute() throws Exception {
        if (this.getData().length != 3) {
            throw new InvalidCommandException(this.getInput());
        }

        String firstPath = this.getData()[1];
        String secondPath = this.getData()[2];
        this.getTester().compareContent(firstPath, secondPath);
    }
}

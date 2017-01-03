package bg.softuni.io.commands;

import bg.softuni.exceptions.InvalidInputException;
import bg.softuni.io.IOManager;
import bg.softuni.judge.Tester;
import bg.softuni.network.DownloadManager;
import bg.softuni.repository.StudentsRepository;

public class MakeDirectoryCommand extends Command {

    public MakeDirectoryCommand(String input,
                                String[] data,
                                StudentsRepository repository,
                                Tester tester,
                                IOManager ioManager,
                                DownloadManager downloadManager) {
        super(input, data, repository, tester, ioManager, downloadManager);
    }

    @Override
    public void execute() throws Exception {
        if (this.getData().length != 2) {
            throw new InvalidInputException(this.getInput());
        }

        String folderName = this.getData()[1];
        this.getIoManager().createDirectoryInCurrentFolder(folderName);
    }
}

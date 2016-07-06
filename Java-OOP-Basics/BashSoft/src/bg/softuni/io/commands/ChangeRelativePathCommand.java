package bg.softuni.io.commands;

import bg.softuni.exceptions.InvalidCommandException;
import bg.softuni.io.IOManager;
import bg.softuni.judge.Tester;
import bg.softuni.network.DownloadManager;
import bg.softuni.repository.StudentsRepository;

public class ChangeRelativePathCommand extends Command {

    public ChangeRelativePathCommand(String input,
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
            throw new InvalidCommandException(this.getInput());
        }

        String relativePath = this.getData()[1];
        this.getIoManager().changeCurrentDirRelativePath(relativePath);
    }
}

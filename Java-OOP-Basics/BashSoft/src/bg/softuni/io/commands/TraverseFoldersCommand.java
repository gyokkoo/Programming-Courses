package bg.softuni.io.commands;

import bg.softuni.exceptions.InvalidCommandException;
import bg.softuni.io.IOManager;
import bg.softuni.judge.Tester;
import bg.softuni.network.DownloadManager;
import bg.softuni.repository.StudentsRepository;

public class TraverseFoldersCommand extends Command {

    public TraverseFoldersCommand(String input,
                                  String[] data,
                                  StudentsRepository repository,
                                  Tester tester,
                                  IOManager ioManager,
                                  DownloadManager downloadManager) {
        super(input, data, repository, tester, ioManager, downloadManager);
    }

    @Override
    public void execute() throws Exception {
        if (this.getData().length != 1 && this.getData().length != 2) {
            throw new InvalidCommandException(this.getInput());
        }

        if (this.getData().length == 1) {
            this.getIoManager().traverseDirectory(0);
        }

        if (this.getData().length == 2) {
            this.getIoManager().traverseDirectory(Integer.valueOf(this.getData()[1]));
        }
    }
}

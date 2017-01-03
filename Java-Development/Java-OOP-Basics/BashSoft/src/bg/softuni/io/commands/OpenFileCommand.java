package bg.softuni.io.commands;

import bg.softuni.exceptions.InvalidInputException;
import bg.softuni.io.IOManager;
import bg.softuni.judge.Tester;
import bg.softuni.network.DownloadManager;
import bg.softuni.repository.StudentsRepository;
import bg.softuni.staticData.SessionData;

import java.awt.*;
import java.io.File;

public class OpenFileCommand extends Command {


    public OpenFileCommand(String input,
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

        String fileName = this.getData()[1];
        String filePath = SessionData.currentPath + "\\" + fileName;
        File file = new File(filePath);
        Desktop.getDesktop().open(file);
    }
}

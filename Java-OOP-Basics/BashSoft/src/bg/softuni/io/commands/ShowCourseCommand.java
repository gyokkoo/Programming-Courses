package bg.softuni.io.commands;

import bg.softuni.exceptions.InvalidCommandException;
import bg.softuni.io.IOManager;
import bg.softuni.judge.Tester;
import bg.softuni.network.DownloadManager;
import bg.softuni.repository.StudentsRepository;

public class ShowCourseCommand extends Command {
    public ShowCourseCommand(String input,
                             String[] data,
                             StudentsRepository repository,
                             Tester tester,
                             IOManager ioManager,
                             DownloadManager downloadManager) {
        super(input, data, repository, tester, ioManager, downloadManager);
    }

    @Override
    public void execute() throws Exception {
        if (this.getData().length != 2 && this.getData().length != 3) {
            throw new InvalidCommandException(this.getInput());
        }

        if (this.getData().length == 2) {
            String courseName = this.getData()[1];
            this.getRepository().getStudentsByCourse(courseName);
        }

        if (this.getData().length == 3) {
            String courseName = this.getData()[1];
            String userName = this.getData()[2];
            this.getRepository().getStudentMarksInCourse(courseName, userName);
        }
    }
}

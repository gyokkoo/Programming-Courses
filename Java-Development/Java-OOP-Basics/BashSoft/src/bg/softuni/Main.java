package bg.softuni;

import bg.softuni.io.CommandInterpreter;
import bg.softuni.io.IOManager;
import bg.softuni.io.InputReader;
import bg.softuni.io.OutputWriter;
import bg.softuni.judge.Tester;
import bg.softuni.network.DownloadManager;
import bg.softuni.repository.RepositoryFilters;
import bg.softuni.repository.RepositorySorters;
import bg.softuni.repository.StudentsRepository;

public class Main {

    public static void main(String[] args) {

        Tester tester = new Tester();
        DownloadManager downloadManager = new DownloadManager();
        IOManager ioManager = new IOManager();
        RepositorySorters sorter = new RepositorySorters();
        RepositoryFilters filter = new RepositoryFilters();
        StudentsRepository repository = new StudentsRepository(filter, sorter);
        CommandInterpreter currentInterpreter =
                new CommandInterpreter(tester, repository, downloadManager, ioManager);
        InputReader reader = new InputReader(currentInterpreter);
        try {
            reader.readCommands();
        } catch (IndexOutOfBoundsException e) {
            throw e;
        } catch (Exception e) {
            OutputWriter.displayException(e.getMessage());
        }
    }
}

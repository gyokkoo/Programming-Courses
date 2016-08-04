package main.bg.softuni.io.commands;

import main.bg.softuni.annotations.Alias;
import main.bg.softuni.annotations.Inject;
import main.bg.softuni.contracts.AsynchDownloader;
import main.bg.softuni.exceptions.InvalidInputException;

@Alias("downloadasynch")
public class DownloadAsynchCommand extends Command {

    @Inject
    private AsynchDownloader downloadManager;

    public DownloadAsynchCommand(String input, String[] data) {
        super(input, data);
    }

    @Override
    public void execute() throws Exception {
        String[] data = this.getData();
        if (data.length != 2) {
            throw new InvalidInputException(this.getInput());
        }

        String fileUrl = data[1];
        this.downloadManager.downloadOnNewThread(fileUrl);
    }
}

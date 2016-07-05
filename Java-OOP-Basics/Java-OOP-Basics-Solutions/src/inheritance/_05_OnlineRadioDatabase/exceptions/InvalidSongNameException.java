package inheritance._05_OnlineRadioDatabase.exceptions;

public class InvalidSongNameException extends InvalidSongException {
    private static final String INVALID_SONG_NAME_MESSAGE = "Song name should be between 3 and 30 symbols.";

    public InvalidSongNameException() {
        super(INVALID_SONG_NAME_MESSAGE);
    }

    public InvalidSongNameException(String message) {
        super(message);
    }
}

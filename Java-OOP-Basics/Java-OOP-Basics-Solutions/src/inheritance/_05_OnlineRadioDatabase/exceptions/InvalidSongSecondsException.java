package inheritance._05_OnlineRadioDatabase.exceptions;

public class InvalidSongSecondsException extends InvalidSongLengthException {
    private static final String INVALID_SONG_SECONDS_MESSAGE = "Song seconds should be between 0 and 59.";

    public InvalidSongSecondsException() {
        super(INVALID_SONG_SECONDS_MESSAGE);
    }

    public InvalidSongSecondsException(String message) {
        super(message);
    }
}

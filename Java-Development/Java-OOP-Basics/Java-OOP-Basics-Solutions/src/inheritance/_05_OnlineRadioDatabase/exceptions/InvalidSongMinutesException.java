package inheritance._05_OnlineRadioDatabase.exceptions;

public class InvalidSongMinutesException extends InvalidSongLengthException {
    private static final String INVALID_SONG_MINUTES_MESSAGE = "Song minutes should be between 0 and 14.";

    public InvalidSongMinutesException() {
        super(INVALID_SONG_MINUTES_MESSAGE);
    }

    public InvalidSongMinutesException(String message) {
        super(message);
    }
}

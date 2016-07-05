package inheritance._05_OnlineRadioDatabase.exceptions;

public class InvalidSongLengthException extends InvalidSongException {
    private static final String INVALID_SONG_LENGTH_MESSAGE = "Invalid song length.";

    public InvalidSongLengthException() {
        super(INVALID_SONG_LENGTH_MESSAGE);
    }

    public InvalidSongLengthException(String message) {
        super(message);
    }
}
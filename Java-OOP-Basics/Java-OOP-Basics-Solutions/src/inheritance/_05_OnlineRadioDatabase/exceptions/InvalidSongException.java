package inheritance._05_OnlineRadioDatabase.exceptions;

public class InvalidSongException extends RuntimeException {
    private static final String INVALID_SONG = "Invalid song.";

    public InvalidSongException() {
        super(INVALID_SONG);
    }

    public InvalidSongException(String message) {
        super(message);
    }
}

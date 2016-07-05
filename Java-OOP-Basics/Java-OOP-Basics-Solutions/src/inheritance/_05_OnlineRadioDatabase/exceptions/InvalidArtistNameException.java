package inheritance._05_OnlineRadioDatabase.exceptions;

public class InvalidArtistNameException extends InvalidSongException {
    private static final String INVALID_ARTIST_NAME_MESSAGE = "Artist name should be between 3 and 20 symbols.";

    public InvalidArtistNameException() {
        super(INVALID_ARTIST_NAME_MESSAGE);
    }

    public InvalidArtistNameException(String message) {
        super(message);
    }
}

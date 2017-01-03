package bg.softuni.exceptions;

public class InvalidCommandException extends RuntimeException {
    private static final String INVALID_COMMAND = "The command '%s' is invalid";

    public InvalidCommandException(String message) {
        super(String.format(INVALID_COMMAND, message));
    }
}

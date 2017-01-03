package enumerationAndAnnotations._08_CardGame.exceptions;

public class NoSuchCardInDeckException extends RuntimeException {

    private static final String NO_SUCH_CARD_MESSAGE = "Card is not in the deck.";

    public NoSuchCardInDeckException() {
        super(NO_SUCH_CARD_MESSAGE);
    }
}

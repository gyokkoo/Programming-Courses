package enumerationAndAnnotations._07_DeckOfCards.enums;

import enumerationAndAnnotations._07_DeckOfCards.CardAnnotation;

@CardAnnotation(
        type = "Enumeration",
        category =  "Suit",
        description =  "Provides suit constants for a Card class."
)
public enum CardSuit {
    CLUBS(0),
    DIAMONDS(13),
    HEARTS(26),
    SPADES(39);

    private int suitPower;

    private CardSuit(int power) {
        this.setSuitPower(power);
    }

    public int getSuitPower() {
        return suitPower;
    }

    private void setSuitPower(int suitPower) {
        this.suitPower = suitPower;
    }
}

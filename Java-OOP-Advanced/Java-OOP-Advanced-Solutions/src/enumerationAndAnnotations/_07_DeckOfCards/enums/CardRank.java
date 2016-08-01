package enumerationAndAnnotations._07_DeckOfCards.enums;

import enumerationAndAnnotations._07_DeckOfCards.CardAnnotation;

@CardAnnotation(
        type = "Enumeration",
        category = "Rank",
        description = "Provides rank constants for a Card class."
)
public enum CardRank {
    ACE(14),
    TWO(2),
    THREE(3),
    FOUR(4),
    FIVE(5),
    SIX(6),
    SEVEN(7),
    EIGHT(8),
    NINE(9),
    TEN(10),
    JACK(11),
    QUEEN(12),
    KING(13);

    private int rankPower;

    private CardRank(int rankPower) {
        this.setPower(rankPower);
    }

    public int getPower() {
        return this.rankPower;
    }

    private void setPower(int power) {
        this.rankPower = power;
    }
}
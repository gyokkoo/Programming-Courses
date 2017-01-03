package enumerationAndAnnotations._04_CardToString;

import enumerationAndAnnotations._04_CardToString.enums.CardRank;
import enumerationAndAnnotations._04_CardToString.enums.CardSuit;

public class Card {

    private CardRank cardRank;
    private CardSuit cardSuit;
    private int cardPower;

    public Card(CardRank cardRank, CardSuit cardSuit) {
        this.setCardRank(cardRank);
        this.setCardSuit(cardSuit);
        this.calculateCardPower();
    }

    public int getCardPower() {
        return cardPower;
    }

    private void calculateCardPower() {
        this.cardPower = this.getCardRank().getPower() +
                this.getCardSuit().getSuitPower();
    }

    public CardRank getCardRank() {
        return this.cardRank;
    }

    private void setCardRank(CardRank cardRank) {
        this.cardRank = cardRank;
    }

    public CardSuit getCardSuit() {
        return this.cardSuit;
    }

    private void setCardSuit(CardSuit cardSuit) {
        this.cardSuit = cardSuit;
    }

    @Override
    public String toString() {
        return String.format("Card name: %s of %s; Card power: %d",
                this.getCardRank().name(),
                this.getCardSuit().name(),
                this.getCardPower());
    }
}

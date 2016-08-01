package enumerationAndAnnotations._03_CardsWithPower;

import enumerationAndAnnotations._03_CardsWithPower.enums.CardRank;
import enumerationAndAnnotations._03_CardsWithPower.enums.CardSuit;

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
}

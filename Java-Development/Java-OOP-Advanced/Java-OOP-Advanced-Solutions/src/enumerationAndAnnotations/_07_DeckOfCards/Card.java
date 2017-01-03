package enumerationAndAnnotations._07_DeckOfCards;

import enumerationAndAnnotations._07_DeckOfCards.enums.CardRank;
import enumerationAndAnnotations._07_DeckOfCards.enums.CardSuit;

public class Card implements Comparable<Card> {

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
        return String.format("%s of %s", this.getCardRank(), this.getCardSuit());
    }

    @Override
    public int compareTo(Card otherCard) {
        return Integer.compare(this.getCardPower(), otherCard.getCardPower());
    }
}

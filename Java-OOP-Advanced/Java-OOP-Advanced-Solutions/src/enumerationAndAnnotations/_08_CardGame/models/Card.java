package enumerationAndAnnotations._08_CardGame.models;

import enumerationAndAnnotations._08_CardGame.enums.CardRank;
import enumerationAndAnnotations._08_CardGame.enums.CardSuit;

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

    @Override
    public boolean equals(Object obj) {
        if (!(obj instanceof Card)) {
            return false;
        }

        Card otherCard = (Card) obj;
        return this.getCardSuit().getSuitPower() == otherCard.getCardSuit().getSuitPower() &&
                this.getCardRank().getPower() == otherCard.getCardRank().getPower();
    }
}
package enumerationAndAnnotations._08_CardGame.models;

import enumerationAndAnnotations._08_CardGame.enums.CardRank;
import enumerationAndAnnotations._08_CardGame.enums.CardSuit;
import enumerationAndAnnotations._08_CardGame.exceptions.NoSuchCardInDeckException;

import java.util.ArrayList;
import java.util.List;

public class CardDeck {

    private List<Card> cards;

    public CardDeck(CardRank[] cardRanks, CardSuit[] cardSuits) {
        this.cards = new ArrayList<>();
        this.addAllCardsToDeck(cardRanks, cardSuits);
    }

    public boolean contains(Card card) {
        return this.cards.contains(card);
    }

    public void remove(Card card) {
        if (!cards.contains(card)) {
            throw new NoSuchCardInDeckException();
        }

        this.cards.remove(card);
    }

    private void addAllCardsToDeck(CardRank[] cardRanks, CardSuit[] cardSuits) {
        for (CardSuit cardSuit : cardSuits) {
            for (CardRank cardRank : cardRanks) {
                Card card = new Card(cardRank, cardSuit);
                this.cards.add(card);
            }
        }
    }
}
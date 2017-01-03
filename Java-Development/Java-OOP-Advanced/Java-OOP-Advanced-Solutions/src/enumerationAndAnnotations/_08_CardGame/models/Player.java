package enumerationAndAnnotations._08_CardGame.models;

import java.util.ArrayList;
import java.util.List;

public class Player {

    private String name;
    private List<Card> playerCards;

    public Player(String name) {
        this.setName(name);
        this.playerCards = new ArrayList<>();
    }

    private String getName() {
        return name;
    }

    private void setName(String name) {
        this.name = name;
    }

    public void addCard(Card card) {
        this.playerCards.add(card);
    }

    public int getCardsCount() {
        return this.playerCards.size();
    }

    public Card getBiggestCard() {
        Card biggestCard = this.playerCards.get(0);
        for (Card currentCard : this.playerCards) {
            if (currentCard.compareTo(biggestCard) > 0) {
                biggestCard = currentCard;
            }
        }

        return biggestCard;
    }

    @Override
    public String toString() {
        return String.format("%s wins with %s of %s.",
                this.getName(),
                this.getBiggestCard().getCardRank().name(),
                this.getBiggestCard().getCardSuit().name());
    }
}
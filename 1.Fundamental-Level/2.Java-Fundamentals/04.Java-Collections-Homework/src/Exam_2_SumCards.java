import java.util.Scanner;
//https://judge.softuni.bg/Contests/Practice/Index/14#1

public class Exam_2_SumCards {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String inputLine = scanner.nextLine();

        int sum = 0;
        if(inputLine.length() == 2) {
            sum += Integer.parseInt(inputLine.charAt(0) + "");
        } else {
            String[] cards = (inputLine + " ").split("\\w ");

            String currentCard = cards[0];
            int cardValue = getCardValue(currentCard);
            if(cards.length > 1) {
                if(currentCard.equals(cards[1])) {
                    sum += cardValue * 2;
                } else {
                    sum += cardValue;
                }
            }

            for (int i = 1; i < cards.length - 1 ; i++) {
                currentCard = cards[i];
                cardValue = getCardValue(currentCard);
                if(currentCard.equals(cards[i - 1]) ||
                    currentCard.equals(cards[i + 1])) {
                    sum += cardValue * 2;
                } else {
                    sum += cardValue;
                }
            }

            currentCard = cards[cards.length - 1];
            cardValue = getCardValue(currentCard);
            if(cards.length > 1) {
                if(currentCard.equals(cards[cards.length - 2])) {
                    sum += cardValue * 2;
                } else {
                    sum += cardValue;
                }
            }
        }
        System.out.println(sum);
    }

    private static int getCardValue(String card) {
        switch (card) {
            case "2": return 2;
            case "3": return 3;
            case "4": return 4;
            case "5": return 5;
            case "6": return 6;
            case "7": return 7;
            case "8": return 8;
            case "9": return 9;
            case "10": return 10;
            case "J": return 12;
            case "Q": return 13;
            case "K": return 14;
            case "A": return 15;
        }
        return -1;
    }
}

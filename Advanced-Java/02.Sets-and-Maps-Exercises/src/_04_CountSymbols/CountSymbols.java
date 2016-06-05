package _04_CountSymbols;

import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;

public class CountSymbols {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String text = scanner.nextLine();

        TreeMap<Character, Integer> symbolsCount = new TreeMap<>();
        for (int i = 0; i < text.length(); i++) {
            Character symbol = text.charAt(i);
            if (!symbolsCount.containsKey(symbol)) {
                symbolsCount.put(symbol, 0);
            }

            int count = symbolsCount.get(symbol) + 1;
            symbolsCount.put(symbol, count);
        }

        for (Map.Entry<Character, Integer> symbol : symbolsCount.entrySet()) {
            System.out.printf("%s: %d time/s%n", symbol.getKey(), symbol.getValue());
        }
    }
}

import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class _4_CouplesFrequency {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String[] inputLine = scanner.nextLine().split(" ");
        int[] numbers = new int[inputLine.length];
        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = Integer.parseInt(inputLine[i]);
        }

        LinkedHashMap<String, Double> couples = new LinkedHashMap<>();

        int totalFrequency = 0;
        for (int i = 0; i < numbers.length - 1; i++) {
            String couple = numbers[i] + " " + numbers[i + 1];
            double frequencyCounter = 0;
            for (int j = i; j < numbers.length - 1 ; j++) {
                String searchCouple = numbers[j] + " " + numbers[j + 1];
                if(couple.equals(searchCouple)) {
                    frequencyCounter++;
                }
            }
            if(!couples.containsKey(couple)) {
                couples.put(couple, frequencyCounter);
                totalFrequency += frequencyCounter;
            }
        }
        for (Map.Entry<String, Double> couple : couples.entrySet()) {
            System.out.printf("%s -> %.2f%%\n", couple.getKey(), couple.getValue() / totalFrequency * 100);
        }
    }
}

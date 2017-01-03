package generics._06_GenericCountMethodDoubles;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        List<Box<Double>> doubleBoxes = new ArrayList<>();
        double n = Double.parseDouble(reader.readLine());
        for (int i = 0; i < n; i++) {
            Double value = Double.valueOf(reader.readLine());
            Box<Double> box = new Box<>(value);
            doubleBoxes.add(box);
        }

        Double valueOfElement = Double.valueOf(reader.readLine());
        Box<Double> boxToCompare = new Box<>(valueOfElement);
        int result = getCountGreaterThanElement(doubleBoxes, boxToCompare);
        System.out.println(result);
    }

    private static <T extends Comparable<T>> int getCountGreaterThanElement(List<Box<T>> list, Box<T> boxToCompare) {
        int counter = 0;
        for (Box<T> currentBox : list) {
            if (currentBox.getValue().compareTo(boxToCompare.getValue()) > 0) {
                counter++;
            }
        }

        return counter;
    }
}

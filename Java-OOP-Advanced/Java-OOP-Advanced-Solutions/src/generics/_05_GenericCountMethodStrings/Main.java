package generics._05_GenericCountMethodStrings;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        List<Box<String>> stringBoxes = new ArrayList<>();
        int n = Integer.parseInt(reader.readLine());
        for (int i = 0; i < n; i++) {
            String value = reader.readLine();
            Box<String> box = new Box<>(value);
            stringBoxes.add(box);
        }

        String valueOfElement = reader.readLine();
        Box<String> boxToCompare = new Box<>(valueOfElement);
        int result = getCountGreaterThanElement(stringBoxes, boxToCompare);
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

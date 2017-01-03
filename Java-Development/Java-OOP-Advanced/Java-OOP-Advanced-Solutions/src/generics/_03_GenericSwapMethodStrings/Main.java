package generics._03_GenericSwapMethodStrings;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.List;

public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        List<Box> boxStrings = new ArrayList<>();
        int n = Integer.parseInt(reader.readLine());
        for (int i = 0; i < n; i++) {
            String str = reader.readLine();
            Box<String> box = new Box<>(str);
            boxStrings.add(box);
        }

        String[] swapIndexes = reader.readLine().split(" ");
        int firstIndex = Integer.parseInt(swapIndexes[0]);
        int secondIndex = Integer.parseInt(swapIndexes[1]);
        swapValues(boxStrings, firstIndex, secondIndex);

        boxStrings.forEach(System.out::println);
    }

    private static <T> void swapValues(List<T> list, int firstIndex, int secondIndex) {
        T firstElementToSwap = list.get(firstIndex);
        T secondElementToSwap = list.get(secondIndex);

        list.set(firstIndex, secondElementToSwap);
        list.set(secondIndex, firstElementToSwap);
    }
}

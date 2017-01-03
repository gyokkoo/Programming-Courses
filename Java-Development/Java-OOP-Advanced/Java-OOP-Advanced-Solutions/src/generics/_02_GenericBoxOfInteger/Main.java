package generics._02_GenericBoxOfInteger;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int n = Integer.parseInt(reader.readLine());
        for (int i = 0; i < n; i++) {
            Integer integer = Integer.valueOf(reader.readLine());
            Box<Integer> box = new Box<>(integer);
            System.out.println(box);
        }
    }
}

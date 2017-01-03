package generics._01_GenericBox;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class Main {

    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int n = Integer.parseInt(reader.readLine());
        for (int i = 0; i < n; i++) {
            String str = reader.readLine();
            Box<String> box = new Box<>(str);
            System.out.println(box);
        }
    }
}

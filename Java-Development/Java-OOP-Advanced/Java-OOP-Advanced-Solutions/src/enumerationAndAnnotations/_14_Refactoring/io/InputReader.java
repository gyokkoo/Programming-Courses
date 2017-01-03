package enumerationAndAnnotations._14_Refactoring.io;

import enumerationAndAnnotations._14_Refactoring.interfaces.Reader;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class InputReader implements Reader {

    private BufferedReader reader;

    public InputReader() {
        reader = new BufferedReader(new InputStreamReader(System.in));
    }

    @Override
    public String read() throws IOException {
        return reader.readLine();
    }
}

package main.bg.softuni.contracts;

import java.io.IOException;

public interface ContentComparer {

    public void compareContent(String actualOutput, String expectedOutput) throws IOException;
}
